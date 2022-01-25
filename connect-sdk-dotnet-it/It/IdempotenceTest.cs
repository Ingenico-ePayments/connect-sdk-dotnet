using NUnit.Framework;
using System;
using Ingenico.Connect.Sdk.Domain.Payment;
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;
using Ingenico.Connect.Sdk.Domain.Definitions;
using System.Threading.Tasks;

namespace Ingenico.Connect.Sdk.It
{
    public class IdemPotenceTest : IntegrationTest
    {
        /// <summary>
        /// Smoke Test for idempotence.
        /// </summary>
        [TestCase]
        public async Task Test()
        {
            CreatePaymentRequest body = new CreatePaymentRequest();

            Order order = new Order();

            AmountOfMoney amountOfMoney = new AmountOfMoney();
            amountOfMoney.CurrencyCode = ("EUR");
            amountOfMoney.Amount = (100L);
            order.AmountOfMoney = (amountOfMoney);

            Customer customer = new Customer();
            customer.Locale = ("en");

            Address billingAddress = new Address();
            billingAddress.CountryCode = ("NL");
            customer.BillingAddress = (billingAddress);

            order.Customer = (customer);
            body.Order = (order);

            RedirectionData redirectionData = new RedirectionData();
            redirectionData.ReturnUrl = ("http://example.com/");

            RedirectPaymentMethodSpecificInput paymentMethodSpecificInput = new RedirectPaymentMethodSpecificInput();
            paymentMethodSpecificInput.RedirectionData = redirectionData;
            paymentMethodSpecificInput.PaymentProductId = (809);

            RedirectPaymentProduct809SpecificInput paymentProductSpecificInput = new RedirectPaymentProduct809SpecificInput();
            paymentProductSpecificInput.IssuerId = ("INGBNL2A");
            paymentMethodSpecificInput.PaymentProduct809SpecificInput = (paymentProductSpecificInput);

            body.RedirectPaymentMethodSpecificInput = (paymentMethodSpecificInput);

            string idempotenceKey = Guid.NewGuid().ToString();
            CallContext context = new CallContext().WithIdempotenceKey(idempotenceKey);

            using (Client client = GetClient())
            {
                CreatePaymentResult result = await doCreatePayment(client, body, context);
                string paymentId = result.Payment.Id;
                string status = result.Payment.Status;

                Assert.AreEqual(idempotenceKey, context.IdempotenceKey);
                Assert.Null(context.IdempotenceRequestTimestamp);

                result = await doCreatePayment(client, body, context);

                Assert.AreEqual(paymentId, result.Payment.Id);
                Assert.AreEqual(status, result.Payment.Status);

                Assert.AreEqual(idempotenceKey, context.IdempotenceKey);
                Assert.NotNull(context.IdempotenceRequestTimestamp);
            }
        }

        private async Task<CreatePaymentResult> doCreatePayment(Client client, CreatePaymentRequest body, CallContext context) {
            // For this test it doesn't matter if the response is successful or declined,
            // as long as idempotence is handled correctly
            try
            {
                return await client.Merchant(GetMerchantId()).Payments().Create(body, context);
            } catch (DeclinedPaymentException e) {
                return e.CreatePaymentResult;
            }
        }
    }
}
