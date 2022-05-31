using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Text.RegularExpressions;

namespace Ingenico.Connect.Sdk.Logging
{
    /// <summary>
    /// A class that can be used to obfuscate properties in JSON bodies. Thread-safe if all its obfuscation rules are.
    /// </summary>
    public class BodyObfuscator
    {
        static readonly BodyObfuscator DEFAULT_OBFUSCATOR = Custom().Build();

        readonly IDictionary<string, ObfuscationRule> _obfuscationRules;
        readonly Regex _propertyRegex;

        BodyObfuscator(IDictionary<string, ObfuscationRule> obfuscationRules)
        {
            _obfuscationRules = ImmutableDictionary.ToImmutableDictionary(obfuscationRules);
            _propertyRegex = BuildPropertyPattern(obfuscationRules.Keys);
        }

        Regex BuildPropertyPattern(IEnumerable<string> propertyNames)
        {
            if (propertyNames.IsEmpty())
            {
                // no matches possible
                return new Regex("$^");
            }

            IEnumerator<string> iterator = propertyNames.GetEnumerator();

            /*
             * Regex to create: (["'])(X|Y|Z)\1\s*:\s*(?:(["'])(.*?)(?<!\\)\3|([^"'\s\[\{][\S-[,]]*))
             * Groups:
             * 1: opening " or ' for the property name
             * 2: property name
             * 3: opening " or ' for the value
             * 4: quoted value
             * 5: non-quoted-value
             * The negative lookbehind is to allow escaped quotes to be part of the value.
             * What this does not allow currently is having values end with a \ (which would be escaped to \\).
             */

            StringBuilder regexStringBuilder = new StringBuilder();
            regexStringBuilder.Append("([\"'])(");
            if (iterator.MoveNext())
            {
                regexStringBuilder.Append(Regex.Escape(iterator.Current));
            }
            while (iterator.MoveNext())
            {
                regexStringBuilder.Append('|').Append(Regex.Escape(iterator.Current));
            }
            regexStringBuilder.Append(")\\1\\s*:\\s*(?:([\"'])(.*?)(?<!\\\\)\\3|([^\"'\\s\\[\\{][\\S-[,]]*))");

            return new Regex(regexStringBuilder.ToString(), RegexOptions.Multiline);
        }

        string ObfuscateValue(string propertyName, string value)
        {
            if (_obfuscationRules.TryGetValue(propertyName, out ObfuscationRule obfuscationRule))
            {
                return obfuscationRule(value);
            }
            return value;
        }

        /// <summary>
        /// Obfuscates the given body as necessary.
        /// </summary>
        public string ObfuscateBody(string body)
        {
            if (string.IsNullOrEmpty(body))
            {
                return body;
            }

            StringBuilder sb = new StringBuilder(body.Length);
            int index = 0;
            foreach (Match matcher in _propertyRegex.Matches(body))
            {
                string propertyName = matcher.Groups[2].Value;
                Group valueGroup = matcher.Groups[4];
                if (!valueGroup.Success)
                {
                    valueGroup = matcher.Groups[5];
                }
                string value = valueGroup.Value;
                int valueStart = valueGroup.Index;
                int valueEnd = valueGroup.Index + valueGroup.Length;

                string obfuscatedValue = ObfuscateValue(propertyName, value);

                sb.Append(body, index, valueStart - index);
                sb.Append(obfuscatedValue);
                index = valueEnd;
            }
            sb.Append(body, index, body.Length - index);

            return sb.ToString();
        }

        /// <summary>
        /// Returns a builder to create custom body obfuscators.
        /// This builder will contain some pre-defined obfuscation rules.These cannot be removed,
        /// but replacing them is possible.
        /// </summary>
        public static Builder Custom()
        {
            return new Builder()
                    .ObfuscateAllButLast(4, "cardNumber")
                    .ObfuscateAllButLast(2, "expiryDate")
                    .ObfuscateAll("cvv")
                    .ObfuscateAllButLast(4, "iban")
                    .ObfuscateAllButLast(4, "accountNumber")
                    .ObfuscateAllButLast(4, "reformattedAccountNumber")
                    .ObfuscateAllButFirst(6, "bin")
                    // key-value pairs can contain any value, like credit card numbers or other private data; mask all values
                    .ObfuscateAll("value")
                    .ObfuscateWithFixedLength(8, "keyId")
                    .ObfuscateWithFixedLength(8, "secretKey")
                    .ObfuscateWithFixedLength(8, "publicKey")
                    .ObfuscateWithFixedLength(8, "userAuthenticationToken")
                    // encrypted payload is a base64 string that contains an encrypted value; to make decrypting even harder, just mask the entire thing
                    .ObfuscateWithFixedLength(8, "encryptedPayload")
                    // decrypted payload is a simple base64 string that may contain credit card numbers or other private data; just mask the entire thing
                    .ObfuscateWithFixedLength(8, "decryptedPayload")
                    // encrypted customer input is similar to encrypted payload
                    .ObfuscateWithFixedLength(8, "encryptedCustomerInput");
        }

        /// <summary>
        /// Returns a default body obfuscator.
        /// The result will be equivalent to calling Custom().Build().
        /// </summary>
        public static BodyObfuscator DefaultObfuscator => DEFAULT_OBFUSCATOR;

        public class Builder
        {
            /// <summary>
            /// Adds an obfuscation rule that will replace all characters with *.
            /// </summary>
            public Builder ObfuscateAll(string propertyName)
            {
                ObfuscationRules[propertyName] = ValueObfuscator.ALL.ObfuscateValue;
                return this;
            }

            /// <summary>
            /// Adds an obfuscation rule that will replace values with a fixed length string containing only *.
            /// </summary>
            public Builder ObfuscateWithFixedLength(int fixedLength, string propertyName)
            {
                ObfuscationRules[propertyName] = ValueObfuscator.FixedLength(fixedLength).ObfuscateValue;
                return this;
            }

            /// <summary>
            /// Adds an obfuscation rule that will keep a fixed number of characters at the start,
            /// then replaces all other characters with *.
            /// </summary>
            public Builder ObfuscateAllButFirst(int count, string propertyName)
            {
                ObfuscationRules[propertyName] = ValueObfuscator.KeepingStartCount(count).ObfuscateValue;
                return this;
            }

            /// <summary>
            /// Adds an obfuscation rule that will keep a fixed number of characters at the end,
            /// then replaces all other characters with *.
            /// </summary>
            public Builder ObfuscateAllButLast(int count, string propertyName)
            {
                ObfuscationRules[propertyName] = ValueObfuscator.KeepingEndCount(count).ObfuscateValue;
                return this;
            }

            /// <summary>
            /// Adds a custom, non-null obfuscation rule.
            /// </summary>
            public Builder ObfuscateCustom(string propertyName, ObfuscationRule obfuscationRule)
            {
                ObfuscationRules[propertyName] = obfuscationRule ?? throw new ArgumentException("obfuscationRule is required");
                return this;
            }

            public BodyObfuscator Build()
            {
                return new BodyObfuscator(this.ObfuscationRules);
            }

            internal Builder()
            {
            }

            IDictionary<string, ObfuscationRule> ObfuscationRules { get; } = new Dictionary<string, ObfuscationRule>();
        }
    }
}
