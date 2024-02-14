using System;

namespace Ingenico.Connect.Sdk
{
    internal static class UriUtils
    {
        internal static bool HasPath(this Uri apiEndpoint)
            => !string.IsNullOrEmpty(apiEndpoint.LocalPath) && !apiEndpoint.LocalPath.Equals("/");

        internal static bool HasUserInfoOrQueryOrFragment(this Uri apiEndpoint)
            => !string.IsNullOrEmpty(apiEndpoint.UserInfo) || !string.IsNullOrEmpty(apiEndpoint.Query) || !string.IsNullOrEmpty(apiEndpoint.Fragment);
    }
}
