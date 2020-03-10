using Ingenico.Connect.Sdk.Domain.Refund;
using Ingenico.Connect.Sdk.Domain.Refund.Definitions;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// Represents an error response from a refund call.
    /// </summary>
    public class DeclinedRefundException : DeclinedTransactionException
    {
        /// <summary>
        /// Gets the result of creating a refund if available, otherwise <code>null</code>.
        /// </summary>
        public RefundResult RefundResult => _errors?.RefundResult;

        public DeclinedRefundException(System.Net.HttpStatusCode statusCode, string responseBody, RefundErrorResponse errors)
            : base(BuildMessage(errors), statusCode, responseBody, errors?.ErrorId, errors?.Errors)
        {
            _errors = errors;
        }

        readonly RefundErrorResponse _errors;

        static string BuildMessage(RefundErrorResponse errors)
        {
            RefundResult refund = errors?.RefundResult;
            if (refund != null)
            {
                return "declined refund '" + refund.Id + "' with status '" + refund.Status + "'";
            }
            return "the Ingenico ePayments platform returned a declined refund response";
        }
    }
}
