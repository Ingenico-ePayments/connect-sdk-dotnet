/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Product.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_DirectoryEntry">DirectoryEntry</a>
    /// </summary>
    public class DirectoryEntry
    {
        public IList<string> CountryNames { get; set; } = null;

        public string IssuerId { get; set; } = null;

        public string IssuerList { get; set; } = null;

        public string IssuerName { get; set; } = null;
    }
}
