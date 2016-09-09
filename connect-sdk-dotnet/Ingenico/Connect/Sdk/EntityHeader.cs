using System;

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
            Value = value;
        }

        #region IResponseHeader, IResponseHeader Implementation
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets or sets the un-encoded value.
        /// </summary>
        public string Value { get; private set; }
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
