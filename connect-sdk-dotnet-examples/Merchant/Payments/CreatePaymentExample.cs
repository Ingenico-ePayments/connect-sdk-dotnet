/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Errors.Definitions;
using Ingenico.Connect.Sdk.Domain.Payment;
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Merchant.Payments
{
    public class CreatePaymentExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                Card card = new Card();
                card.CardNumber = "4567350000427977";
                card.CardholderName = "Wile E. Coyote";
                card.Cvv = "123";
                card.ExpiryDate = "1220";

                AmountOfMoney authenticationAmount = new AmountOfMoney();
                authenticationAmount.Amount = 2980L;
                authenticationAmount.CurrencyCode = "EUR";

                RedirectionData redirectionData = new RedirectionData();
                redirectionData.ReturnUrl = "https://hostname.myownwebsite.url";

                ThreeDSecure threeDSecure = new ThreeDSecure();
                threeDSecure.AuthenticationAmount = authenticationAmount;
                threeDSecure.AuthenticationFlow = "browser";
                threeDSecure.ChallengeCanvasSize = "600x400";
                threeDSecure.ChallengeIndicator = "challenge-requested";
                threeDSecure.ExemptionRequest = "none";
                threeDSecure.RedirectionData = redirectionData;
                threeDSecure.SkipAuthentication = false;

                CardPaymentMethodSpecificInput cardPaymentMethodSpecificInput = new CardPaymentMethodSpecificInput();
                cardPaymentMethodSpecificInput.Card = card;
                cardPaymentMethodSpecificInput.IsRecurring = false;
                cardPaymentMethodSpecificInput.MerchantInitiatedReasonIndicator = "delayedCharges";
                cardPaymentMethodSpecificInput.PaymentProductId = 1;
                cardPaymentMethodSpecificInput.ThreeDSecure = threeDSecure;
                cardPaymentMethodSpecificInput.TransactionChannel = "ECOMMERCE";

                AmountOfMoney amountOfMoney = new AmountOfMoney();
                amountOfMoney.Amount = 2980L;
                amountOfMoney.CurrencyCode = "EUR";

                Address billingAddress = new Address();
                billingAddress.AdditionalInfo = "b";
                billingAddress.City = "Monument Valley";
                billingAddress.CountryCode = "US";
                billingAddress.HouseNumber = "13";
                billingAddress.State = "Utah";
                billingAddress.Street = "Desertroad";
                billingAddress.Zip = "84536";

                CompanyInformation companyInformation = new CompanyInformation();
                companyInformation.Name = "Acme Labs";
                companyInformation.VatNumber = "1234AB5678CD";

                ContactDetails contactDetails = new ContactDetails();
                contactDetails.EmailAddress = "wile.e.coyote@acmelabs.com";
                contactDetails.FaxNumber = "+1234567891";
                contactDetails.PhoneNumber = "+1234567890";

                BrowserData browserData = new BrowserData();
                browserData.ColorDepth = 24;
                browserData.JavaEnabled = false;
                browserData.ScreenHeight = "1200";
                browserData.ScreenWidth = "1920";

                CustomerDevice device = new CustomerDevice();
                device.AcceptHeader = "texthtml,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                device.BrowserData = browserData;
                device.IpAddress = "123.123.123.123";
                device.Locale = "en-US";
                device.TimezoneOffsetUtcMinutes = "420";
                device.UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_4) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.1 Safari/605.1.15";

                PersonalName name = new PersonalName();
                name.FirstName = "Wile";
                name.Surname = "Coyote";
                name.SurnamePrefix = "E.";
                name.Title = "Mr.";

                PersonalInformation personalInformation = new PersonalInformation();
                personalInformation.DateOfBirth = "19490917";
                personalInformation.Gender = "male";
                personalInformation.Name = name;

                Customer customer = new Customer();
                customer.AccountType = "none";
                customer.BillingAddress = billingAddress;
                customer.CompanyInformation = companyInformation;
                customer.ContactDetails = contactDetails;
                customer.Device = device;
                customer.Locale = "en_US";
                customer.MerchantCustomerId = "1234";
                customer.PersonalInformation = personalInformation;

                OrderInvoiceData invoiceData = new OrderInvoiceData();
                invoiceData.InvoiceDate = "20140306191500";
                invoiceData.InvoiceNumber = "000000123";

                OrderReferences references = new OrderReferences();
                references.Descriptor = "Fast and Furry-ous";
                references.InvoiceData = invoiceData;
                references.MerchantOrderId = 123456L;
                references.MerchantReference = "AcmeOrder0001";

                PersonalName shippingName = new PersonalName();
                shippingName.FirstName = "Road";
                shippingName.Surname = "Runner";
                shippingName.Title = "Miss";

                AddressPersonal address = new AddressPersonal();
                address.AdditionalInfo = "Suite II";
                address.City = "Monument Valley";
                address.CountryCode = "US";
                address.HouseNumber = "1";
                address.Name = shippingName;
                address.State = "Utah";
                address.Street = "Desertroad";
                address.Zip = "84536";

                Shipping shipping = new Shipping();
                shipping.Address = address;

                IList<LineItem> items = new List<LineItem>();

                AmountOfMoney item1AmountOfMoney = new AmountOfMoney();
                item1AmountOfMoney.Amount = 2500L;
                item1AmountOfMoney.CurrencyCode = "EUR";

                LineItemInvoiceData item1InvoiceData = new LineItemInvoiceData();
                item1InvoiceData.Description = "ACME Super Outfit";
                item1InvoiceData.NrOfItems = "1";
                item1InvoiceData.PricePerItem = 2500L;

                LineItem item1 = new LineItem();
                item1.AmountOfMoney = item1AmountOfMoney;
                item1.InvoiceData = item1InvoiceData;

                items.Add(item1);

                AmountOfMoney item2AmountOfMoney = new AmountOfMoney();
                item2AmountOfMoney.Amount = 480L;
                item2AmountOfMoney.CurrencyCode = "EUR";

                LineItemInvoiceData item2InvoiceData = new LineItemInvoiceData();
                item2InvoiceData.Description = "Aspirin";
                item2InvoiceData.NrOfItems = "12";
                item2InvoiceData.PricePerItem = 40L;

                LineItem item2 = new LineItem();
                item2.AmountOfMoney = item2AmountOfMoney;
                item2.InvoiceData = item2InvoiceData;

                items.Add(item2);

                ShoppingCart shoppingCart = new ShoppingCart();
                shoppingCart.Items = items;

                Order order = new Order();
                order.AmountOfMoney = amountOfMoney;
                order.Customer = customer;
                order.References = references;
                order.Shipping = shipping;
                order.ShoppingCart = shoppingCart;

                CreatePaymentRequest body = new CreatePaymentRequest();
                body.CardPaymentMethodSpecificInput = cardPaymentMethodSpecificInput;
                body.Order = order;

                try
                {
                    CreatePaymentResponse response = await client.Merchant("merchantId").Payments().Create(body);
                }
                catch (DeclinedPaymentException e)
                {
                    HandleDeclinedPayment(e.CreatePaymentResult);
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

        private void HandleDeclinedPayment(CreatePaymentResult createPaymentResult)
        {
            // handle the result here
        }

        private void HandleApiErrors(IList<APIError> errors)
        {
            // handle the errors here
        }
    }
}
