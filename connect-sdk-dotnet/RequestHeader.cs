using System;
using System.Text.RegularExpressions;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// A single request header. Immutable.
    /// </summary>
    public class RequestHeader : IRequestHeader
    {
        public RequestHeader(string name, string value)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name is required");
            }
            Name = name;
            Value = NormalizeValue(value);
        }

        private string NormalizeValue(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return value;
            }
            // Replace all sequences of linebreak-whitespace* with a single linebreak-space
            // This matches the normalization done by DefaultAuthenticator, and ensures that multiline headers
            // will not cause authentication failures
            var pattern = "\r?\n[\\s-[\r\n]]*";
            var newString = new Regex(pattern, RegexOptions.Multiline | RegexOptions.CultureInvariant).Replace(value, " ").Trim();
            return newString;
        }

        #region IRequestHeader
        public string Name { get; }

        public string Value { get; }
        #endregion

        public override string ToString() => Name + ":" + Value;

        public override int GetHashCode()
            => Tuple.Create(Name, Value).GetHashCode();

        public bool Equals(RequestHeader obj)
            => (obj?.Name?.Equals(Name) ?? false)
                && (obj?.Value?.Equals(Value) ?? false);

        public override bool Equals(object obj)
            => obj is RequestHeader && Equals(obj as RequestHeader);
    }
}
