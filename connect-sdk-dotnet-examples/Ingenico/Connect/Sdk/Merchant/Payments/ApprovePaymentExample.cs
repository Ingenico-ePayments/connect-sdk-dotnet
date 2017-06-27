/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Payment;
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;

namespace Ingenico.Connect.Sdk.Merchant.Payments
{
    public class ApprovePaymentExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                ApprovePaymentNonSepaDirectDebitPaymentMethodSpecificInput directDebitPaymentMethodSpecificInput = new ApprovePaymentNonSepaDirectDebitPaymentMethodSpecificInput();
                directDebitPaymentMethodSpecificInput.DateCollect = "20150201";
                directDebitPaymentMethodSpecificInput.Token = "bfa8a7e4-4530-455a-858d-204ba2afb77e";

                OrderReferencesApprovePayment references = new OrderReferencesApprovePayment();
                references.MerchantReference = "AcmeOrder0001";

                OrderApprovePayment order = new OrderApprovePayment();
                order.References = references;

                ApprovePaymentRequest body = new ApprovePaymentRequest();
                body.Amount = 2980L;
                body.DirectDebitPaymentMethodSpecificInput = directDebitPaymentMethodSpecificInput;
                body.Order = order;

                PaymentApprovalResponse response = await client.Merchant("merchantId").Payments().Approve("paymentId", body);
            }
#pragma warning restore 0168
        }

        private Client GetClient()
        {
            string apiKeyId = "someKey";
            string secretApiKey = "someSecret";

            CommunicatorConfiguration configuration = Factory.CreateConfiguration(apiKeyId, secretApiKey);
            return Factory.CreateClient(configuration);
        }
    }
}
