using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ingenico.Connect.Sdk
{
    static class UriUtils
    {
        internal static bool HasPath(this Uri apiEndpoint)
            => !string.IsNullOrEmpty(apiEndpoint.LocalPath) && !apiEndpoint.LocalPath.Equals("/");

        internal static bool HasUserInfoOrQueryOrFragment(this Uri apiEndpoint)
            => !string.IsNullOrEmpty(apiEndpoint.UserInfo) || !string.IsNullOrEmpty(apiEndpoint.Query) || !string.IsNullOrEmpty(apiEndpoint.Fragment);
    }
}
