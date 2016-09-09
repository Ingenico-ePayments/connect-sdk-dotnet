namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// A single request header. Immutable.
    /// </summary>
    public interface IRequestHeader
    {
        /// <summary>
        /// Gets the name of the header.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the un-encoded value of the header.
        /// </summary>
        string Value { get; }
    }
}
