using System;
using System.Collections;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// Represents a set of request parameters.
    /// </summary>
    abstract public class AbstractParamRequest
    {
        abstract public IEnumerable<RequestParam> ToRequestParameters();

        /// <summary>
        /// Adds a request parameter with the given name and value to the given list, unless if the value if <code>null</code>.
        /// </summary>
        /// <remarks>
        ///     The following types are supported for <code>value</code>:
        ///     <list type="bullet">
        ///         <item> <description><see cref="string"/></description> </item>
        ///         <item> <description><see cref="int"/></description> </item>
        ///         <item> <description><see cref="bool"/></description> </item>
        ///         <item> <description><see cref="IEnumerable"/> of above</description> </item>
        ///     </list>
        /// </remarks>
        public void AddParameter(IList<RequestParam> requestParamaters, string name, object value)
        {
            AddParameter(requestParamaters, name, value, true);
        }

        void AddParameter(IList<RequestParam> requestParameters, string name, object value, bool allowCollection)
        {
            var valueType = value?.GetType();
            if (typeof(string).IsAssignableFrom(valueType))
            {
                requestParameters.Add(new RequestParam(name, (string)value));
            }
            else if (typeof(int).IsAssignableFrom(valueType) || typeof(long).IsAssignableFrom(valueType) || typeof(bool).IsAssignableFrom(valueType))
            {
                requestParameters.Add(new RequestParam(name, value.ToString().ToLower()));
            }
            else if (allowCollection && typeof(IEnumerable).IsAssignableFrom(valueType))
            {
                IEnumerable values = (IEnumerable)value;
                foreach (var element in values)
                {
                    AddParameter(requestParameters, name, element, false);
                }
            }
            else if (value != null)
            {
                throw new ArgumentException("Unsupported requestParameter type");
            }
        }
    }
}
