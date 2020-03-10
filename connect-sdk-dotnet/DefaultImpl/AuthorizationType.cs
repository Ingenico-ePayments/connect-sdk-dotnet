using System;

namespace Ingenico.Connect.Sdk.DefaultImpl
{
    public class AuthorizationType
    {
        #region enum
        public static readonly AuthorizationType V1HMAC = new AuthorizationType("v1HMAC");
        #endregion

        #region Static
        /// <summary>
        /// Returns the enum value of the specified string.
        /// </summary>
        public static AuthorizationType GetValueOf(string aString)
        {
            if (aString?.Equals("v1HMAC") ?? false)
            {
                return V1HMAC;
            }
            throw new ArgumentException("Unsupported Authorization");
        }
        #endregion

        public string SignatureString { get; }

        AuthorizationType(string signatureString)
        {
            SignatureString = signatureString;
        }
    }
}
