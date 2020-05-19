using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Ingenico.Connect.Sdk.Logging
{
    internal class PropertyObfuscator : Obfuscator
    {
        readonly Regex _propertyRegex;

        PropertyObfuscator(IDictionary<string, ValueObfuscator> obfuscators)
            : base(obfuscators, false)
        {
            _propertyRegex = BuildPropertyPattern(obfuscators.Keys);
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

        public string Obfuscate(string body)
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

        public static PropertyObfuscatorBuilder Builder()
        {
            return new PropertyObfuscatorBuilder();
        }

        public class PropertyObfuscatorBuilder
        {
            IDictionary<string, ValueObfuscator> Obfuscators { get; set; }
                = new Dictionary<string, ValueObfuscator>();

            public PropertyObfuscatorBuilder WithAll(string property)
            {
                Obfuscators.Add(property, ValueObfuscator.ALL);
                return this;
            }

            public PropertyObfuscatorBuilder WithFixedLength(string property, int fixedLength)
            {
                Obfuscators.Add(property, ValueObfuscator.FixedLength(fixedLength));
                return this;
            }

            public PropertyObfuscatorBuilder WithKeepStartCount(string key, int count)
            {
                Obfuscators.Add(key, ValueObfuscator.KeepingStartCount(count));
                return this;
            }

            public PropertyObfuscatorBuilder WithKeepEndCount(string property, int count)
            {
                Obfuscators.Add(property, ValueObfuscator.KeepingEndCount(count));
                return this;
            }

            public PropertyObfuscator Build()
            {
                return new PropertyObfuscator(this.Obfuscators);
            }
        }
    }
}
