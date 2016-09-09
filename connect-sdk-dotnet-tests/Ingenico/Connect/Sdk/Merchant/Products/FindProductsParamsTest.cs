using NUnit.Framework;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Merchant.Products
{
    [TestFixture]
    public class FindProductsParamsTest
    {
        [TestCase]
        public void TestToRequestParameters()
        {
            var lParams = new FindProductsParams();
            var paramList = new List<RequestParam>();

            Assert.That(lParams.ToRequestParameters(), Is.EquivalentTo(paramList));

            lParams.Amount = 1000L;
            paramList.Add(new RequestParam("amount", "1000"));
            Assert.That(lParams.ToRequestParameters(), Is.EquivalentTo(paramList));

            lParams.CountryCode = "NL";
            paramList.Add(new RequestParam("countryCode", "NL"));
            Assert.That(lParams.ToRequestParameters(), Is.EquivalentTo(paramList));

            lParams.CurrencyCode = "EUR";
            paramList.Add(new RequestParam("currencyCode", "EUR"));
            Assert.That(lParams.ToRequestParameters(), Is.EquivalentTo(paramList));

            lParams.IsRecurring = true;
            paramList.Add(new RequestParam("isRecurring", "true"));
            Assert.That(lParams.ToRequestParameters(), Is.EquivalentTo(paramList));

            lParams.Locale = "nl_NL";
            paramList.Add(new RequestParam("locale", "nl_NL"));
            Assert.That(lParams.ToRequestParameters(), Is.EquivalentTo(paramList));

            lParams.AddHide("fields");
            paramList.Add(new RequestParam("hide", "fields"));
            Assert.That(lParams.ToRequestParameters(), Is.EquivalentTo(paramList));

            lParams.AddHide("accountsOnFile");
            paramList.Add(new RequestParam("hide", "accountsOnFile"));
            Assert.That(lParams.ToRequestParameters(), Is.EquivalentTo(paramList));

            lParams.Amount = null;
            paramList.RemoveAt(0);
            Assert.That(lParams.ToRequestParameters(), Is.EquivalentTo(paramList));
        }
    }
}
