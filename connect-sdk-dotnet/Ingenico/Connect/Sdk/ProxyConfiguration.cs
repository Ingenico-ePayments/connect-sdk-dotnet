using System;
using System.Configuration;

namespace Ingenico.Connect.Sdk
{
    class ProxyConfiguration : UriConfiguration
    {
        public ProxyConfiguration(Uri address)
            : this(address, null, null)
        {

        }

        public ProxyConfiguration(Uri address, string username, string password)
            : this(address.Scheme, address.Host, address.Port, username, password)
        {

        }

        public ProxyConfiguration(string host, int port)
            : this("http", host, port)
        {

        }

        public ProxyConfiguration(string host, int port, string username, string password)
            : this("http", host, port, username, password)
        {

        }


        public ProxyConfiguration(string scheme, string host, int port)
            : this(scheme, host, port, null, null)
        {

        }

        public ProxyConfiguration(string scheme, string host, int port, string username, string password)
        {
            if (string.IsNullOrWhiteSpace(scheme))
            {
                throw new ArgumentException("scheme is required");
            }
            if (string.IsNullOrWhiteSpace(host))
            {
                throw new ArgumentException("host is required");
            }
            if (port <= 0 || port > 65535)
            {
                throw new ArgumentException("port is invalid");
            }
            Scheme = scheme;
            Host = host;
            Port = port;
            Username = username;
            Password = password;
        }

        [ConfigurationProperty("username", IsRequired = false)]
        public string Username
        {
            get
            {
                if (_username == null)
                {
                    return (string)this["username"];

                }
                return _username;
            }
            set
            {
                if (IsReadOnly())
                {
                    _username = value;
                    return;
                }
                this["username"] = value;
            }

        }
        string _username;

        [ConfigurationProperty("password", IsRequired = false)]
        public string Password
        {
            get
            {
                if (_password == null)
                {
                    return (string)this["password"];

                }
                return _password;
            }
            set
            {
                if (IsReadOnly())
                {
                    _password = value;
                    return;
                }
                this["password"] = value;
            }
        }
        string _password;

        public ProxyConfiguration WithUsername(string username)
        {
            Username = username;
            return this;
        }

        public ProxyConfiguration WithPassword(string password)
        {
            Password = password;
            return this;
        }

        /// <summary>
        /// Initializes an empty ProxyConfiguration (possibly invalid)
        /// </summary>
        internal ProxyConfiguration()
        {

        }
    }
}
