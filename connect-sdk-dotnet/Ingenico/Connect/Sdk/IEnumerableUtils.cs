using System.Collections.Generic;
using System.Linq;

namespace Ingenico.Connect.Sdk
{
    static class IEnumerableUtils
    {
        internal static bool IsEmpty<T>(this IEnumerable<T> collection)
            => !collection.Any();

        internal static bool IsNullOrEmpty<T>(this IEnumerable<T> collection)
            => collection == null || collection.IsEmpty();

        internal static IEnumerable<T> NullIfEmpty<T>(this IEnumerable<T> collection)
            => collection.Any() ? collection : null;
    }
}
