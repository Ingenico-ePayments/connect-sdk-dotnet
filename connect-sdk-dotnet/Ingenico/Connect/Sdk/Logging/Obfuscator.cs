using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Ingenico.Connect.Sdk.Logging
{
    class Obfuscator
    {
        public string ObfuscateValue(string key, string value)
        {
            ValueObfuscator obfuscator;
            if (_obfuscators.TryGetValue(key, out obfuscator))
            {
                return obfuscator.ObfuscateValue(value);
            }
            return value;
        }

        protected Obfuscator(IDictionary<string, ValueObfuscator> obfuscators, bool caseInsensitive)
        {
            if (caseInsensitive)
            {
                _obfuscators = ImmutableDictionary.ToImmutableDictionary(obfuscators, StringComparer.OrdinalIgnoreCase);
            }
            else
            {
                _obfuscators = ImmutableDictionary.ToImmutableDictionary(obfuscators);
            }
        }

        readonly IDictionary<string, ValueObfuscator> _obfuscators;
    }
}
