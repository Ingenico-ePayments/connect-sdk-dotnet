using System;
using System.Linq;

namespace Ingenico.Connect.Sdk
{
    public class ShoppingCartExtension
    {
        public string Creator => _creator;
        readonly string _creator;

        public string Name => _name;
        readonly string _name;

        public string Version => _version;
        readonly string _version;

        public ShoppingCartExtension(string creator, string name, string version)
        {
            if (creator == null || !creator.Trim().Any())
            {
                throw new ArgumentException("creator is required");
            }
            if (name == null || !name.Trim().Any())
            {
                throw new ArgumentException("name is required");
            }
            if (version == null || !version.Trim().Any())
            {
                throw new ArgumentException("version is required");
            }
            _creator = creator;
            _name = name;
            _version = version;
        }

        // Only for testing
        internal ShoppingCartExtension()
        {

        }
    }
}
