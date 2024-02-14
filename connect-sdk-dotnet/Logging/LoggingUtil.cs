namespace Ingenico.Connect.Sdk.Logging
{
    /// <summary>
    /// A utility class to support logging.
    /// </summary>
    /// [ObsoleteAttribute("Use BodyObfuscator and HeaderObfuscator instead")]
    public class LoggingUtil
    {
        /// <summary>
        /// Obfuscates the given body as necessary.
        /// </summary>
        public static string ObfuscateBody(string body)
        {
            return BodyObfuscator.DefaultObfuscator.ObfuscateBody(body);
        }

        /// <summary>
        /// Obfuscates the value for the given header as necessary.
        /// </summary>
        public static string ObfuscateHeader(string name, string value)
        {
            return HeaderObfuscator.DefaultObfuscator.ObfuscateHeader(name, value);
        }

        LoggingUtil()
        {
        }
    }
}
