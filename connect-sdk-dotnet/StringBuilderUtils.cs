using System.Text;

namespace Ingenico.Connect.Sdk
{
    internal static class StringBuilderUtils
    {
        internal static StringBuilder AppendLLine(this StringBuilder sb, string aString)
            => sb.Append(aString).Append("\n");
    }
}
