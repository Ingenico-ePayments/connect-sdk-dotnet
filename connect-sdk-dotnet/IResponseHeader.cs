namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// A single response header. Immutable.
    /// </summary>
    public interface IResponseHeader
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
