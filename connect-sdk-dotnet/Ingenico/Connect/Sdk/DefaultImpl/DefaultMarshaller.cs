using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Ingenico.Connect.Sdk.DefaultImpl
{
    /// <summary>
    /// <see cref="IMarshaller"/> implementation based on <a href="http://www.newtonsoft.com/json">Json.NET</a>.
    /// </summary>
    public sealed class DefaultMarshaller : IMarshaller
    {
        public static DefaultMarshaller Instance => _instance;
        static readonly DefaultMarshaller _instance = new DefaultMarshaller();

        #region IMarshaller Implementation
        public string Marshal(object requestObject) => JsonConvert.SerializeObject(requestObject, _jsonSerializerSettings);

        public T Unmarshal<T>(string responseJson)
        {
            try
            {
                T anObject = (T)JsonConvert.DeserializeObject(responseJson, typeof(T), _jsonSerializerSettings);
                return anObject;
            }
            catch (JsonReaderException exception)
            {
                throw new MarshallerSyntaxException(exception);
            }
        }
        #endregion

        static readonly JsonSerializerSettings _jsonSerializerSettings = new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseKeepFullCapsNamingStrategy()
            },
            NullValueHandling = NullValueHandling.Ignore
        };

        DefaultMarshaller() { }
    }
}
