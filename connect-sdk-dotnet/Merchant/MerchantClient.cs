/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Merchant.Captures;
using Ingenico.Connect.Sdk.Merchant.Disputes;
using Ingenico.Connect.Sdk.Merchant.Files;
using Ingenico.Connect.Sdk.Merchant.Hostedcheckouts;
using Ingenico.Connect.Sdk.Merchant.Hostedmandatemanagements;
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
        /// </summary>
        /// <returns>HostedcheckoutsClient</returns>
        public HostedcheckoutsClient Hostedcheckouts()
        {
            return new HostedcheckoutsClient(this, null);
        }

        /// <summary>
        /// Resource /{merchantId}/hostedmandatemanagements
        /// </summary>
        /// <returns>HostedmandatemanagementsClient</returns>
        public HostedmandatemanagementsClient Hostedmandatemanagements()
        {
            return new HostedmandatemanagementsClient(this, null);
        }

        /// <summary>
        /// Resource /{merchantId}/payments
        /// </summary>
        /// <returns>PaymentsClient</returns>
        public PaymentsClient Payments()
        {
            return new PaymentsClient(this, null);
        }

        /// <summary>
        /// Resource /{merchantId}/captures
        /// </summary>
        /// <returns>CapturesClient</returns>
        public CapturesClient Captures()
        {
            return new CapturesClient(this, null);
        }

        /// <summary>
        /// Resource /{merchantId}/refunds
        /// </summary>
        /// <returns>RefundsClient</returns>
        public RefundsClient Refunds()
        {
            return new RefundsClient(this, null);
        }

        /// <summary>
        /// Resource /{merchantId}/disputes
        /// </summary>
        /// <returns>DisputesClient</returns>
        public DisputesClient Disputes()
        {
            return new DisputesClient(this, null);
        }

        /// <summary>
        /// Resource /{merchantId}/payouts
        /// </summary>
        /// <returns>PayoutsClient</returns>
        public PayoutsClient Payouts()
        {
            return new PayoutsClient(this, null);
        }

        /// <summary>
        /// Resource /{merchantId}/productgroups
        /// </summary>
        /// <returns>ProductgroupsClient</returns>
        public ProductgroupsClient Productgroups()
        {
            return new ProductgroupsClient(this, null);
        }

        /// <summary>
        /// Resource /{merchantId}/products
        /// </summary>
        /// <returns>ProductsClient</returns>
        public ProductsClient Products()
        {
            return new ProductsClient(this, null);
        }

        /// <summary>
        /// Resource /{merchantId}/riskassessments
        /// </summary>
        /// <returns>RiskassessmentsClient</returns>
        public RiskassessmentsClient Riskassessments()
        {
            return new RiskassessmentsClient(this, null);
        }

        /// <summary>
        /// Resource /{merchantId}/services
        /// </summary>
        /// <returns>ServicesClient</returns>
        public ServicesClient Services()
        {
            return new ServicesClient(this, null);
        }

        /// <summary>
        /// Resource /{merchantId}/tokens
        /// </summary>
        /// <returns>TokensClient</returns>
        public TokensClient Tokens()
        {
            return new TokensClient(this, null);
        }

        /// <summary>
        /// Resource /{merchantId}/mandates
        /// </summary>
        /// <returns>MandatesClient</returns>
        public MandatesClient Mandates()
        {
            return new MandatesClient(this, null);
        }

        /// <summary>
        /// Resource /{merchantId}/sessions
        /// </summary>
        /// <returns>SessionsClient</returns>
        public SessionsClient Sessions()
        {
            return new SessionsClient(this, null);
        }

        /// <summary>
        /// Resource /{merchantId}/files
        /// </summary>
        /// <returns>FilesClient</returns>
        public FilesClient Files()
        {
            return new FilesClient(this, null);
        }
    }
}
