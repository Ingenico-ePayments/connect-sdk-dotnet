using System.IO;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// Used to marshal and unmarshal Ingenico ePayments platform request and response objects to and from JSON. Thread-safe.
    /// </summary>
    public interface IMarshaller
    {
        /// <summary>
        /// Marshal a request object to a JSON string.
        /// </summary>
        /// <param name="requestObject">The request object.</param>
        string Marshal(object requestObject);

        /// <summary>
        /// Unmarshal a JSON string to a response object.
        /// </summary>
        /// <param name="responseJson">The JSON that will be parsed.</param>
        /// <typeparam name="T">The response type.</typeparam>
        /// <exception cref="MarshallerSyntaxException">if the JSON is not a valid representation for an object of the given type</exception>
        T Unmarshal<T>(string responseJson);

        /// <summary>
        /// Unmarshal JSON from a stream to a response object.
        /// </summary>
        /// <param name="responseJson">The stream containing a valid JSON string.</param>
        /// <typeparam name="T">The response type.</typeparam>
        /// <exception cref="MarshallerSyntaxException">if the JSON is not a valid representation for an object of the given type</exception>
        T Unmarshal<T>(Stream responseJson);
    }
}
