using System.Text;

namespace Ingenico.Connect.Sdk
{
    static class StringBuilderUtils
    {
        internal static StringBuilder AppendLLine(this StringBuilder sb, string aString)
            => sb.Append(aString).Append("\n");
    }
}
