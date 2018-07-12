/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Hostedcheckout;
using Ingenico.Connect.Sdk.Domain.Hostedcheckout.Definitions;
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;

namespace Ingenico.Connect.Sdk.Merchant.Hostedcheckouts
{
    public class CreateHostedCheckoutExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                HostedCheckoutSpecificInput hostedCheckoutSpecificInput = new HostedCheckoutSpecificInput();
                hostedCheckoutSpecificInput.Locale = "en_GB";
                hostedCheckoutSpecificInput.Variant = "testVariant";

                AmountOfMoney amountOfMoney = new AmountOfMoney();
                amountOfMoney.Amount = 2345L;
                amountOfMoney.CurrencyCode = "USD";

                Address billingAddress = new Address();
                billingAddress.CountryCode = "US";

                Customer customer = new Customer();
                customer.BillingAddress = billingAddress;
                customer.MerchantCustomerId = "1234";

                Order order = new Order();
                order.AmountOfMoney = amountOfMoney;
                order.Customer = customer;

                CreateHostedCheckoutRequest body = new CreateHostedCheckoutRequest();
                body.HostedCheckoutSpecificInput = hostedCheckoutSpecificInput;
                body.Order = order;

                CreateHostedCheckoutResponse response = await client.Merchant("merchantId").Hostedcheckouts().Create(body);
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
