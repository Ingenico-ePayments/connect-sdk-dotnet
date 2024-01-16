using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace Ingenico.Connect.Sdk.Webhooks
{
    /// <summary>
    /// Validator for webhooks signatures. Thread-safe.
    /// </summary>
    public class SignatureValidator
    {
        static bool SignaturePredicate(IRequestHeader h) => h.Name.Equals("X-GCS-Signature", StringComparison.InvariantCultureIgnoreCase);
        static bool KeyIdPredicate(IRequestHeader h) => h.Name.Equals("X-GCS-KeyId", StringComparison.InvariantCultureIgnoreCase);

        readonly ISecretKeyStore _secretKeyStore;

        public SignatureValidator(ISecretKeyStore secretKeyStore)
        {
            _secretKeyStore = secretKeyStore ?? throw new ArgumentNullException("secretKeyStore is required");
        }

        /// <summary>
        /// Validates the given body using the given request headers.
        /// </summary>
        /// <exception cref="SignatureValidationException"> If the body could not be validated sucessfully</exception>
        /// <exception cref="ApiVersionMismatchException"> If the resulting event has an API version that this version of the SDK does not support.</exception>
        public void Validate(string body, IEnumerable<IRequestHeader> requestHeaders)
        {
            Validate(StringUtils.Encoding.GetBytes(body), requestHeaders);
        }

        /// <summary>
        /// Validates the given body using the given request headers.
        /// </summary>
        /// <exception cref="SignatureValidationException"> If the body could not be validated sucessfully</exception>
        /// <exception cref="ApiVersionMismatchException"> If the resulting event has an API version that this version of the SDK does not support.</exception>
        public void Validate(byte[] body, IEnumerable<IRequestHeader> requestHeaders)
        {
            ValidateBody(body, requestHeaders);
        }

        private void ValidateBody(byte[] body, IEnumerable<IRequestHeader> requestHeaders)
        {
            var numberOfSignatureHeaders = requestHeaders.Count(SignaturePredicate);
            if (numberOfSignatureHeaders == 0)
            {
                throw new SignatureValidationException("Missing X-GCS-Signature header");
            }
            if (numberOfSignatureHeaders != 1)
            {
                throw new SignatureValidationException("Duplicate X-GCS-Signature header");
            }

            var numberOfKeyIdHeaders = requestHeaders.Count(KeyIdPredicate);
            if (numberOfKeyIdHeaders == 0)
            {
                throw new SignatureValidationException("Missing X-GCS-KeyId header");
            }
            if (numberOfKeyIdHeaders != 1)
            {
                throw new SignatureValidationException("Duplicate X-GCS-KeyId header");
            }

            var signature = requestHeaders.SingleOrDefault(SignaturePredicate)?.Value;

            var keyId = requestHeaders.SingleOrDefault(KeyIdPredicate)?.Value;

            using (var mac = new HMACSHA256(StringUtils.Encoding.GetBytes(_secretKeyStore.GetSecretKey(keyId))))
            {
                mac.Initialize();
                byte[] unencodedResult = mac.ComputeHash(body);
                var expectedSignature = Convert.ToBase64String(unencodedResult);
                bool isValid = signature.CompareWithoutTimingLeak(expectedSignature);
                if (!isValid)
                {
                    throw new SignatureValidationException("failed to validate signature '" + signature + "'");
                }
            }
        }
    }
}
