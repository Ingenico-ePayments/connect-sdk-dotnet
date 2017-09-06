using System;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// Indicates an exception regarding the communication with the Ingenico ePayments platform such as a connection exception.
    /// </summary>
    public class CommunicationException : Exception
    {
        public CommunicationException(Exception e)
            : base("There was an error in the communication with the Ingenico ePayments platform", e)
        {
            
        }
    }
}
