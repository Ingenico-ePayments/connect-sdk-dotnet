using System;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// A single response header. Immutable.
    /// </summary>
    public class ResponseHeader : IResponseHeader
    {
        public ResponseHeader(string name, string value)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name is required");
            }
            Name = name;
            Value = value;
        }

        #region IResponseHeader
        public string Name { get; }

        public string Value { get; }
        #endregion

        public override string ToString() => Name + ";" + Value;

        public override int GetHashCode()
            => Tuple.Create(Name, Value).GetHashCode();

        public bool Equals(ResponseHeader obj)
            => (obj?.Name?.Equals(Name) ?? false)
                && (obj?.Value?.Equals(Value) ?? false);

        public override bool Equals(object obj)
            => obj is ResponseHeader && Equals(obj as ResponseHeader);
    }
}
