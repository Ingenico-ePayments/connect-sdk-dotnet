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
                _obfuscators.Add(property, ValueObfuscator.ALL);
                return this;
            }

            public HeaderObfuscatorBuilder WithFixedLength(string property, int fixedLength)
            {
                _obfuscators.Add(property, ValueObfuscator.FixedLength(fixedLength));
                return this;
            }

            public HeaderObfuscatorBuilder WithKeepStartCount(string key, int count)
            {
                _obfuscators.Add(key, ValueObfuscator.KeepingStartCount(count));
                return this;
            }

            public HeaderObfuscatorBuilder WithKeepEndCount(string property, int count)
            {
                _obfuscators.Add(property, ValueObfuscator.KeepingEndCount(count));
                return this;
            }

            public HeaderObfuscator Build()
            {
                return new HeaderObfuscator(this._obfuscators);
            }

            IDictionary<string, ValueObfuscator> _obfuscators { get; set; }
                = new Dictionary<string, ValueObfuscator>();

        }
        HeaderObfuscator(IDictionary<string, ValueObfuscator> obfuscators)
            : base(obfuscators, true)
        {

        }
    }
}
