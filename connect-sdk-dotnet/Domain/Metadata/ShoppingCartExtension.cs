using System;
using System.Linq;

namespace Ingenico.Connect.Sdk
{
    public class ShoppingCartExtension
    {
        public string Creator { get; }

        public string Name { get; }

        public string Version { get; }

        public string ExtensionId { get; }

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
            Creator = creator;
            Name = name;
            Version = version;
            ExtensionId = null;
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
            Creator = creator;
            Name = name;
            Version = version;
            ExtensionId = extensionId;
        }

        // Only for testing
        internal ShoppingCartExtension()
        {

        }
    }
}
