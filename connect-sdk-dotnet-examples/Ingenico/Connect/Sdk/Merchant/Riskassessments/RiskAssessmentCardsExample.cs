/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Riskassessments;
using Ingenico.Connect.Sdk.Domain.Riskassessments.Definitions;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Merchant.Riskassessments
{
    public class RiskAssessmentCardsExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                Card card = new Card();
                card.CardNumber = "4567350000427977";
                card.Cvv = "123";
                card.ExpiryDate = "0820";

                IList<AirlineFlightLeg> flightLegs = new List<AirlineFlightLeg>();

                AirlineFlightLeg flightLeg1 = new AirlineFlightLeg();
                flightLeg1.AirlineClass = "1";
                flightLeg1.ArrivalAirport = "AMS";
                flightLeg1.CarrierCode = "KL";
                flightLeg1.Date = "20150102";
                flightLeg1.DepartureTime = "17:59";
                flightLeg1.Fare = "fare";
                flightLeg1.FareBasis = "INTERNET";
                flightLeg1.FlightNumber = "791";
                flightLeg1.Number = 1;
                flightLeg1.OriginAirport = "BCN";
                flightLeg1.StopoverCode = "non-permitted";

                flightLegs.Add(flightLeg1);

                AirlineFlightLeg flightLeg2 = new AirlineFlightLeg();
                flightLeg2.AirlineClass = "1";
                flightLeg2.ArrivalAirport = "BCN";
                flightLeg2.CarrierCode = "KL";
                flightLeg2.Date = "20150102";
                flightLeg2.DepartureTime = "23:59";
                flightLeg2.Fare = "fare";
                flightLeg2.FareBasis = "INTERNET";
                flightLeg2.FlightNumber = "792";
                flightLeg2.Number = 2;
                flightLeg2.OriginAirport = "AMS";
                flightLeg2.StopoverCode = "non-permitted";

                flightLegs.Add(flightLeg2);

                AirlineData airlineData = new AirlineData();
                airlineData.AgentNumericCode = "123321";
                airlineData.Code = "123";
                airlineData.FlightDate = "20150102";
                airlineData.FlightLegs = flightLegs;
                airlineData.InvoiceNumber = "123456";
                airlineData.IsETicket = true;
                airlineData.IsRestrictedTicket = true;
                airlineData.IsThirdParty = true;
                airlineData.IssueDate = "20150101";
                airlineData.MerchantCustomerId = "14";
                airlineData.Name = "Air France KLM";
                airlineData.PassengerName = "WECOYOTE";
                airlineData.PlaceOfIssue = "Utah";
                airlineData.Pnr = "4JTGKT";
                airlineData.PointOfSale = "IATA point of sale name";
                airlineData.PosCityCode = "AMS";
                airlineData.TicketDeliveryMethod = "e-ticket";
                airlineData.TicketNumber = "KLM20050000";

                AdditionalOrderInputAirlineData additionalInput = new AdditionalOrderInputAirlineData();
                additionalInput.AirlineData = airlineData;

                AmountOfMoney amountOfMoney = new AmountOfMoney();
                amountOfMoney.Amount = 100L;
                amountOfMoney.CurrencyCode = "EUR";

                Address billingAddress = new Address();
                billingAddress.CountryCode = "US";

                CustomerRiskAssessment customer = new CustomerRiskAssessment();
                customer.AccountType = "existing";
                customer.BillingAddress = billingAddress;
                customer.Locale = "en_US";

                OrderRiskAssessment order = new OrderRiskAssessment();
                order.AdditionalInput = additionalInput;
                order.AmountOfMoney = amountOfMoney;
                order.Customer = customer;

                RiskAssessmentCard body = new RiskAssessmentCard();
                body.Card = card;
                body.Order = order;

                RiskAssessmentResponse response = await client.Merchant("merchantId").Riskassessments().Cards(body);
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
