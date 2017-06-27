/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Errors.Definitions;
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;
using Ingenico.Connect.Sdk.Domain.Refund;
using Ingenico.Connect.Sdk.Domain.Refund.Definitions;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Merchant.Payments
{
    public class RefundPaymentExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                AmountOfMoney amountOfMoney = new AmountOfMoney();
                amountOfMoney.Amount = 1L;
                amountOfMoney.CurrencyCode = "EUR";

                BankAccountIban bankAccountIban = new BankAccountIban();
                bankAccountIban.Iban = "NL53INGB0000000036";

                BankRefundMethodSpecificInput bankRefundMethodSpecificInput = new BankRefundMethodSpecificInput();
                bankRefundMethodSpecificInput.BankAccountIban = bankAccountIban;

                PersonalName name = new PersonalName();
                name.Surname = "Coyote";

                AddressPersonal address = new AddressPersonal();
                address.CountryCode = "US";
                address.Name = name;

                ContactDetailsBase contactDetails = new ContactDetailsBase();
                contactDetails.EmailAddress = "wile.e.coyote@acmelabs.com";
                contactDetails.EmailMessageType = "html";

                RefundCustomer customer = new RefundCustomer();
                customer.Address = address;
                customer.ContactDetails = contactDetails;

                RefundReferences refundReferences = new RefundReferences();
                refundReferences.MerchantReference = "AcmeOrder0001";

                RefundRequest body = new RefundRequest();
                body.AmountOfMoney = amountOfMoney;
                body.BankRefundMethodSpecificInput = bankRefundMethodSpecificInput;
                body.Customer = customer;
                body.RefundDate = "20140306";
                body.RefundReferences = refundReferences;

                try
                {
                    RefundResponse response = await client.Merchant("merchantId").Payments().Refund("paymentId", body);
                }
                catch (DeclinedRefundException e)
                {
                    HandleDeclinedRefund(e.RefundResult);
                }
                catch (ApiException e)
                {
                    HandleApiErrors(e.Errors);
                }
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

        private void HandleDeclinedRefund(RefundResult refundResult)
        {
            // handle the result here
        }

        private void HandleApiErrors(IList<APIError> errors)
        {
            // handle the errors here
        }
    }
}
