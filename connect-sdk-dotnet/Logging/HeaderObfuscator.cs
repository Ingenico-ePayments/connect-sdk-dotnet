using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Logging
{
    class HeaderObfuscator : Obfuscator
    {
        public static HeaderObfuscatorBuilder Builder()
        {
            return new HeaderObfuscatorBuilder();
        }

        public class HeaderObfuscatorBuilder
        {
            public HeaderObfuscatorBuilder WithAll(string property)
            {
                Obfuscators.Add(property, ValueObfuscator.ALL);
                return this;
            }

            public HeaderObfuscatorBuilder WithFixedLength(string property, int fixedLength)
            {
                Obfuscators.Add(property, ValueObfuscator.FixedLength(fixedLength));
                return this;
            }

            public HeaderObfuscatorBuilder WithKeepStartCount(string key, int count)
            {
                Obfuscators.Add(key, ValueObfuscator.KeepingStartCount(count));
                return this;
            }

            public HeaderObfuscatorBuilder WithKeepEndCount(string property, int count)
            {
                Obfuscators.Add(property, ValueObfuscator.KeepingEndCount(count));
                return this;
            }

            public HeaderObfuscator Build()
            {
                return new HeaderObfuscator(this.Obfuscators);
            }

            IDictionary<string, ValueObfuscator> Obfuscators { get; }
                = new Dictionary<string, ValueObfuscator>();

        }
        HeaderObfuscator(IDictionary<string, ValueObfuscator> obfuscators)
            : base(obfuscators, true)
        {

        }
    }
}
