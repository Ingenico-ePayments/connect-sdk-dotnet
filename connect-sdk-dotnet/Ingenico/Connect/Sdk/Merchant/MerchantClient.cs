/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Merchant.Captures;
using Ingenico.Connect.Sdk.Merchant.Hostedcheckouts;
using Ingenico.Connect.Sdk.Merchant.Mandates;
using Ingenico.Connect.Sdk.Merchant.Payments;
using Ingenico.Connect.Sdk.Merchant.Payouts;
using Ingenico.Connect.Sdk.Merchant.Productgroups;
using Ingenico.Connect.Sdk.Merchant.Products;
using Ingenico.Connect.Sdk.Merchant.Refunds;
using Ingenico.Connect.Sdk.Merchant.Riskassessments;
using Ingenico.Connect.Sdk.Merchant.Services;
using Ingenico.Connect.Sdk.Merchant.Sessions;
using Ingenico.Connect.Sdk.Merchant.Tokens;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Merchant
{
    /// <summary>
    /// Merchant client. Thread-safe.
    /// </summary>
    public class MerchantClient : ApiResource
    {
        public MerchantClient(ApiResource parent, IDictionary<string, string> pathContext) :
            base(parent, pathContext)
        {
        }

        /// <summary>
        /// Resource /{merchantId}/hostedcheckouts
        /// Create new hosted checkout
        /// </summary>
        /// <returns>HostedcheckoutsClient</returns>
        public HostedcheckoutsClient Hostedcheckouts()
        {
            return new HostedcheckoutsClient(this, null);
        }

        /// <summary>
        /// Resource /{merchantId}/payments
        /// Create, cancel and approve payments
        /// </summary>
        /// <returns>PaymentsClient</returns>
        public PaymentsClient Payments()
        {
            return new PaymentsClient(this, null);
        }

        /// <summary>
        /// Resource /{merchantId}/captures
        /// Get capture
        /// </summary>
        /// <returns>CapturesClient</returns>
        public CapturesClient Captures()
        {
            return new CapturesClient(this, null);
        }

        /// <summary>
        /// Resource /{merchantId}/refunds
        /// Create, cancel and approve refunds
        /// </summary>
        /// <returns>RefundsClient</returns>
        public RefundsClient Refunds()
        {
            return new RefundsClient(this, null);
        }

        /// <summary>
        /// Resource /{merchantId}/payouts
        /// Create, cancel and approve payouts
        /// </summary>
        /// <returns>PayoutsClient</returns>
        public PayoutsClient Payouts()
        {
            return new PayoutsClient(this, null);
        }

        /// <summary>
        /// Resource /{merchantId}/productgroups
        /// Get information about payment product groups
        /// </summary>
        /// <returns>ProductgroupsClient</returns>
        public ProductgroupsClient Productgroups()
        {
            return new ProductgroupsClient(this, null);
        }

        /// <summary>
        /// Resource /{merchantId}/products
        /// Get information about payment products
        /// </summary>
        /// <returns>ProductsClient</returns>
        public ProductsClient Products()
        {
            return new ProductsClient(this, null);
        }

        /// <summary>
        /// Resource /{merchantId}/riskassessments
        /// Perform risk assessments on your customer data
        /// </summary>
        /// <returns>RiskassessmentsClient</returns>
        public RiskassessmentsClient Riskassessments()
        {
            return new RiskassessmentsClient(this, null);
        }

        /// <summary>
        /// Resource /{merchantId}/services
        /// Several services to help you
        /// </summary>
        /// <returns>ServicesClient</returns>
        public ServicesClient Services()
        {
            return new ServicesClient(this, null);
        }

        /// <summary>
        /// Resource /{merchantId}/tokens
        /// Create, delete and update tokens
        /// </summary>
        /// <returns>TokensClient</returns>
        public TokensClient Tokens()
        {
            return new TokensClient(this, null);
        }

        /// <summary>
        /// Resource /{merchantId}/mandates
        /// Create, get and update mandates
        /// </summary>
        /// <returns>MandatesClient</returns>
        public MandatesClient Mandates()
        {
            return new MandatesClient(this, null);
        }

        /// <summary>
        /// Resource /{merchantId}/sessions
        /// Create new Session for Client2Server API calls
        /// </summary>
        /// <returns>SessionsClient</returns>
        public SessionsClient Sessions()
        {
            return new SessionsClient(this, null);
        }
    }
}
