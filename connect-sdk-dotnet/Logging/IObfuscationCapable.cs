using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenico.Connect.Sdk.Logging
{
    /// <summary>
    /// Classes that implement this interface support obfuscating bodies and headers.
    /// </summary>
    public interface IObfuscationCapable
    {
		/// <summary>
		/// The current non-null body obfuscator to use.
		/// </summary>
		BodyObfuscator BodyObfuscator { set; }

		/// <summary>
		/// The current non-null header obfuscator to use.
		/// </summary>
		HeaderObfuscator HeaderObfuscator { set; }
	}
}
