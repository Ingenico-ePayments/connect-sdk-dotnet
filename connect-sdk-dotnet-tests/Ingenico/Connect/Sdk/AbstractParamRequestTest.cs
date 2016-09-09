using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk
{
    [TestFixture]
    public class AbstractParamRequestTest
    {
        // Tests for acceptance of basic parameters
        //
        [TestCase]
        public void TestAddParameterString()
        {
            AbstractParamRequest request = new TestParamRequest();
            IList<RequestParam> requestParameters = new List<RequestParam>();
            request.AddParameter(requestParameters, "Test", "foo");

            IList<RequestParam> expected = new List<RequestParam>() { new RequestParam("Test", "foo") };
            Assert.AreEqual(requestParameters, expected);

        }

        [TestCase]
        public void TestAddParameterInteger()
        {
            AbstractParamRequest request = new TestParamRequest();
            IList<RequestParam> requestParameters = new List<RequestParam>();
            request.AddParameter(requestParameters, "Test", 1);

            IList<RequestParam> expected = new List<RequestParam>() { new RequestParam("Test", "1") };
            Assert.AreEqual(requestParameters, expected);

        }

        [TestCase]
        public void TestAddParameterLong()
        {
            AbstractParamRequest request = new TestParamRequest();
            IList<RequestParam> requestParameters = new List<RequestParam>();
            request.AddParameter(requestParameters, "Test", 1L);

            IList<RequestParam> expected = new List<RequestParam>() { new RequestParam("Test", "1") };
            Assert.AreEqual(requestParameters, expected);

        }

        [TestCase]
        public void TestAddParameterBool()
        {
            AbstractParamRequest request = new TestParamRequest();
            IList<RequestParam> requestParameters = new List<RequestParam>();
            request.AddParameter(requestParameters, "Test", true);

            IList<RequestParam> expected = new List<RequestParam> { new RequestParam("Test", "true") };
            Assert.AreEqual(requestParameters, expected);

        }

        // Tests for acceptance of lists of basic parameters
        //
        [TestCase]
        public void TestAddParameterStringList()
        {
            AbstractParamRequest request = new TestParamRequest();
            IList<RequestParam> requestParameters = new List<RequestParam>();
            IList<string> stringParams = new List<string>();
            string controlCharacterSpam = "\\/!@#%$%^&*\"' foo '\"/\\";
            string brackets = "[{(<!--bar-->)}]";
            stringParams.Add(controlCharacterSpam);
            stringParams.Add(brackets);
            stringParams.Add("");
            request.AddParameter(requestParameters, "Test", stringParams);

            IList<RequestParam> expected = new List<RequestParam>();
            expected.Add(new RequestParam("Test", controlCharacterSpam));
            expected.Add(new RequestParam("Test", brackets));
            expected.Add(new RequestParam("Test", ""));
            Assert.AreEqual(requestParameters, expected);
        }

        [TestCase]
        public void TestAddParameterIntegerList()
        {
            AbstractParamRequest request = new TestParamRequest();
            IList<RequestParam> requestParameters = new List<RequestParam>();
            IList<int> intParams = new List<int>();
            intParams.Add(int.MaxValue);
            intParams.Add(int.MinValue);
            request.AddParameter(requestParameters, "Test", intParams);

            IList<RequestParam> expected = new List<RequestParam>();
            expected.Add(new RequestParam("Test", int.MaxValue.ToString()));
            expected.Add(new RequestParam("Test", int.MinValue.ToString()));
            Assert.AreEqual(requestParameters, expected);
        }

        [TestCase]
        public void TestAddParameterLongList()
        {
            AbstractParamRequest request = new TestParamRequest();
            IList<RequestParam> requestParameters = new List<RequestParam>();
            IList<long> longParams = new List<long>();
            longParams.Add(long.MaxValue);
            longParams.Add(0);
            request.AddParameter(requestParameters, "Test", longParams);

            IList<RequestParam> expected = new List<RequestParam>();
            expected.Add(new RequestParam("Test", long.MaxValue.ToString()));
            expected.Add(new RequestParam("Test", "0"));
            Assert.AreEqual(requestParameters, expected);
        }

        [TestCase]
        public void TestAddParameterBooleanList()
        {
            AbstractParamRequest request = new TestParamRequest();
            IList<RequestParam> requestParameters = new List<RequestParam>();
            IList<bool> boolParams = new List<bool>();
            boolParams.Add(false);
            request.AddParameter(requestParameters, "Test", boolParams);

            IList<RequestParam> expected = new List<RequestParam>();
            expected.Add(new RequestParam("Test", false.ToString().ToLower()));
            Assert.That(requestParameters, Is.EqualTo(expected));
        }

        // Tests for Testing illegal input
        //
        [TestCase]
        public void TestAddParameterDate()
        {
            AbstractParamRequest request = new TestParamRequest();
            IList<RequestParam> requestParameters = new List<RequestParam>();
            IList<DateTime> dateParams = new List<DateTime>();
            dateParams.Add(DateTime.Now);

            Assert.Throws<ArgumentException>(() => request.AddParameter(requestParameters, "Test", dateParams));
        }

        [TestCase]
        public void TestAddParameterStringListList()
        {
            AbstractParamRequest request = new TestParamRequest();
            IList<RequestParam> requestParameters = new List<RequestParam>();
            IList<IEnumerable<string>> stringListListParams = new List<IEnumerable<string>>();
            List<string> foo = new List<string>();
            foo.Add("foo");
            stringListListParams.Add(foo);
            Assert.Throws<ArgumentException>(() => request.AddParameter(requestParameters, "Test", stringListListParams));
        }
    }

    sealed class TestParamRequest : AbstractParamRequest
    {
        public override IEnumerable<RequestParam> ToRequestParameters()
        {
            throw new InvalidOperationException();
        }
    }
}
