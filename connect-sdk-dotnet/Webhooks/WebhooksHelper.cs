using System;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Webhooks
{
    /// <summary>
    /// Ingenico ePayments platform webhooks helper. Thread-safe.
    /// </summary>
    public class WebhooksHelper
    {
        readonly IMarshaller _marshaller;
        readonly SignatureValidator _signatureValidator;

        public WebhooksHelper(IMarshaller marshaller, ISecretKeyStore secretKeyStore)
        {
            _marshaller = marshaller ?? throw new ArgumentNullException("marshaller is required");
            _signatureValidator = new SignatureValidator(secretKeyStore);
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
            _signatureValidator.Validate(body, requestHeaders);
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
            _signatureValidator.Validate(body, requestHeaders);
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
