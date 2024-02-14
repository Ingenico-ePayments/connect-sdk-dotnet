using System.Collections.Generic;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// Represents a set of request parameters.
    /// </summary>
    public abstract class AbstractParamRequest
    {
        public abstract IEnumerable<RequestParam> ToRequestParameters();
    }
}
