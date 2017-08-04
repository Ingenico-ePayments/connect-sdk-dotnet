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

        public string ExtensionId => _extensionId;
        readonly string _extensionId;

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
            _extensionId = null;
        }

        public ShoppingCartExtension(string creator, string name, string version, string extensionId)
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
            if (extensionId == null || !extensionId.Trim().Any())
            {
                throw new ArgumentException("extensionId is required");
            }
            _creator = creator;
            _name = name;
            _version = version;
            _extensionId = extensionId;
        }

        // Only for testing
        internal ShoppingCartExtension()
        {

        }
    }
}
