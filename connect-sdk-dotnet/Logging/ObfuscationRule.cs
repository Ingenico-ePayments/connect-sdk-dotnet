namespace Ingenico.Connect.Sdk.Logging
{
    /// <summary>
    /// An obfuscation rule defines how a single value is obfuscated. This can be as simple as returning a fixed mask, or as complex as necessary.
    /// </summary>
    public delegate string ObfuscationRule(string value);
}
