using System.Collections;
using System.Reflection;

namespace Ingenico.Connect.Sdk.Util
{
    public static class ReflectionUtil
    {
        internal static T GetPrivateProperty<T>(this object instance, string fieldName)
        {
            BindingFlags bindFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
            PropertyInfo property = instance.GetType().GetProperty(fieldName, bindFlags);
            return (T)property.GetValue(instance);

        }
        internal static object GetPrivateField<T>(this T instance, string fieldName)
        {
            BindingFlags bindFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic
                | BindingFlags.Static;
            FieldInfo field = typeof(T).GetField(fieldName, bindFlags);
            return field.GetValue(instance);
        }
        internal static IEnumerable GetFields<T>(this T instance)
        {
            var b = instance.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            foreach (var a in b)
            {
                yield return a;
            }
        }
    }
}
