using System.Collections.Generic;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// Represents a set of request parameters.
    /// </summary>
    abstract public class AbstractParamRequest
    {
        abstract public IEnumerable<RequestParam> ToRequestParameters();
    }
}
