using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace Ingenico.Connect.Sdk.Webhooks
{
    /// <summary>
    /// Ingenico ePayments platform webhooks helper. Thread-safe.
    /// </summary>
    public class WebhooksHelper
    {
        static bool SignaturePredicate(IRequestHeader h) => h.Name.Equals("X-GCS-Signature", StringComparison.InvariantCultureIgnoreCase);
        static bool KeyIdPredicate(IRequestHeader h) => h.Name.Equals("X-GCS-KeyId", StringComparison.InvariantCultureIgnoreCase);

        readonly IMarshaller _marshaller;
        readonly ISecretKeyStore _secretKeyStore;

        public WebhooksHelper(IMarshaller marshaller, ISecretKeyStore secretKeyStore)
        {
            _marshaller = marshaller ?? throw new ArgumentNullException("marshaller is required");
            _secretKeyStore = secretKeyStore ?? throw new ArgumentNullException("secretKeyStore is required");
        }

        /// <summary>
        /// Unmarshals the given body, while also validating it using the given request headers.
        /// </summary>
        /// <exception cref="SignatureValidationException">If the body could not be validated successfully.</exception>
        /// <exception cref="ApiVersionMismatchException"> If the resulting event has an API version that this version of the SDK does not support.</exception>
        public WebhooksEvent Unmarshal(string body, IEnumerable<IRequestHeader> requestHeaders)
        {
            Validate(body, requestHeaders);
            WebhooksEvent unmarshalledEvent = _marshaller.Unmarshal<WebhooksEvent>(body);
            ValidateApiVersion(unmarshalledEvent);
            return unmarshalledEvent;
        }

        /// <summary>
        /// Validates the given body using the given request headers.
        /// </summary>
        /// <exception cref="SignatureValidationException"> If the body could not be validated sucessfully</exception>
        /// <exception cref="ApiVersionMismatchException"> If the resulting event has an API version that this version of the SDK does not support.</exception>
        protected void Validate(string body, IEnumerable<IRequestHeader> requestHeaders)
        {
            Validate(StringUtils.Encoding.GetBytes(body), requestHeaders);
        }

        /// <summary>
        /// Unmarshals the given body, while also validating it using the given request headers.
        /// </summary>
        /// <exception cref="SignatureValidationException">If the body could not be validated successfully.</exception>
        /// <exception cref="ApiVersionMismatchException"> If the resulting event has an API version that this version of the SDK does not support.</exception>
        public WebhooksEvent Unmarshal(byte[] body, IEnumerable<IRequestHeader> requestHeaders)
        {
            Validate(body, requestHeaders);
            WebhooksEvent unmarshalledEvent = _marshaller.Unmarshal<WebhooksEvent>(StringUtils.Encoding.GetString(body));
            ValidateApiVersion(unmarshalledEvent);
            return unmarshalledEvent;
        }

        /// <summary>
        /// Validates the given body using the given request headers.
        /// </summary>
        /// <exception cref="SignatureValidationException"> If the body could not be validated sucessfully</exception>
        /// <exception cref="ApiVersionMismatchException"> If the resulting event has an API version that this version of the SDK does not support.</exception>
        protected void Validate(byte[] body, IEnumerable<IRequestHeader> requestHeaders)
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

        private void ValidateApiVersion(WebhooksEvent unmarshalledEvent)
        {
            if (!Client.ApiVersion.Equals(unmarshalledEvent.ApiVersion))
            {
                throw new ApiVersionMismatchException(unmarshalledEvent.ApiVersion, Client.ApiVersion);
            }
        }
    }
}
