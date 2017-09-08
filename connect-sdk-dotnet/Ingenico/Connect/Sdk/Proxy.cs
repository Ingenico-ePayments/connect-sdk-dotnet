using System;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// Represents a proxy with a URI and it's authentication.
    /// </summary>
    public class Proxy
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Uri Uri { get; set; }
    }
}
