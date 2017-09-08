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
        readonly IMarshaller _marshaller;
        readonly ISecretKeyStore _secretKeyStore;

        public WebhooksHelper(IMarshaller marshaller, ISecretKeyStore secretKeyStore)
        {
            if (marshaller == null)
            {
                throw new ArgumentNullException("marshaller is required");
            }
            if (secretKeyStore == null)
            {
                throw new ArgumentNullException("secretKeyStore is required");
            }
            _marshaller = marshaller;
            _secretKeyStore = secretKeyStore;
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
            Func<IRequestHeader, bool> signaturePredicate = (IRequestHeader h) => h.Name.Equals("X-GCS-Signature", StringComparison.InvariantCultureIgnoreCase);
            Func<IRequestHeader, bool> keyIdPredicate = (IRequestHeader h) => h.Name.Equals("X-GCS-KeyId", StringComparison.InvariantCultureIgnoreCase);
            if (requestHeaders.Count(signaturePredicate) != 1)
            {
                if (requestHeaders.Count(signaturePredicate) == 0)
                {
                    throw new SignatureValidationException("Missing X-GCS-Signature header");
                }
                throw new SignatureValidationException("Duplicate X-GCS-Signature header");
            }
            if (requestHeaders.Count(keyIdPredicate) != 1)
            {
                if (requestHeaders.Count(keyIdPredicate) == 0)
                {
                    throw new SignatureValidationException("Missing X-GCS-KeyId header");
                }
                throw new SignatureValidationException("Duplicate X-GCS-KeyId header");
            }

            var signature = requestHeaders.SingleOrDefault(signaturePredicate)?.Value;

            var keyId = requestHeaders.SingleOrDefault(keyIdPredicate)?.Value;

            var mac = new HMACSHA256(StringUtils.Encoding.GetBytes(_secretKeyStore.GetSecretKey(keyId)));
            mac.Initialize();
            byte[] unencodedResult = mac.ComputeHash(body);
            var expectedSignature = Convert.ToBase64String(unencodedResult);
            bool isValid = signature.CompareWithoutTimingLeak(expectedSignature);
            if (!isValid)
            {
                throw new SignatureValidationException("failed to validate signature '" + signature + "'");
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
