using System;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// Thrown when a JSON string cannot be converted to a response object.
    /// </summary>
    public class MarshallerSyntaxException : Exception
    {
        public MarshallerSyntaxException(Exception e) : base("A syntax error occured during marshalling", e)
        {

        }
    }
}
