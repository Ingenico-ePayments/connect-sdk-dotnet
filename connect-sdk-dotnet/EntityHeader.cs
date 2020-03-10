using System;
using System.Text.RegularExpressions;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// A header that specifies metadata about the content of the request or response. Immutable.
    /// </summary>
    class EntityHeader : IRequestHeader, IResponseHeader
    {
        public EntityHeader(string name, string value)
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
            // Replace all sequences of whitespace*-linebreak-whitespace* into a single linebreak-space
            // This will ensure that:
            // - no line ends with whitespace, because this causes authentication failures
            // - each line starts with a single whitespace, so it is a valid header value
            var pattern = "[\\s-[\r\n]]*(\r?\n)[\\s-[\r\n]]*";
            var newString = new Regex(pattern, RegexOptions.Multiline | RegexOptions.CultureInvariant).Replace(value, "$1 ");
            return newString;
        }

        #region IResponseHeader, IResponseHeader Implementation
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets or sets the un-encoded value.
        /// </summary>
        public string Value { get; }
        #endregion

        public override string ToString() => Name + ";" + Value;

        public override int GetHashCode()
            => Tuple.Create(Name, Value).GetHashCode();

        public bool Equals(EntityHeader obj)
            => (obj?.Name?.Equals(Name) ?? false)
                && (obj?.Value?.Equals(Value) ?? false);

        public override bool Equals(object obj)
            => obj is EntityHeader && Equals(obj as EntityHeader);
    }
}
