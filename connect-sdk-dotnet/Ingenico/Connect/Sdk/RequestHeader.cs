using System;

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
            Value = value;
        }

        #region IRequestHeader
        public string Name { get; private set; }

        public string Value { get; private set; }
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
