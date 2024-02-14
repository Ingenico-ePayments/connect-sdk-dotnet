using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Ingenico.Connect.Sdk.DefaultImpl
{
    /// <summary>
    /// <see cref="IMarshaller"/> implementation based on <a href="http://www.newtonsoft.com/json">Json.NET</a>.
    /// </summary>
    public sealed class DefaultMarshaller : IMarshaller
    {
        public static DefaultMarshaller Instance { get; } = new DefaultMarshaller();

        #region IMarshaller Implementation
        public string Marshal(object requestObject) => JsonConvert.SerializeObject(requestObject, JsonSerializerSettings);

        public T Unmarshal<T>(string responseJson)
        {
            try
            {
                T anObject = (T)JsonConvert.DeserializeObject(responseJson, typeof(T), JsonSerializerSettings);
                return anObject;
            }
            catch (JsonReaderException exception)
            {
                throw new MarshallerSyntaxException(exception);
            }
        }

        public T Unmarshal<T>(Stream responseJson)
        {
            try
            {
                var sr = new StreamReader(responseJson);
                JsonReader jr = new JsonTextReader(sr);
                var serializer = JsonSerializer.Create(JsonSerializerSettings);

                T anObject = serializer.Deserialize<T>(jr);
                return anObject;
            }
            catch (JsonReaderException exception)
            {
                throw new MarshallerSyntaxException(exception);
            }

        }

        #endregion

        static readonly JsonSerializerSettings JsonSerializerSettings = new JsonSerializerSettings
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
