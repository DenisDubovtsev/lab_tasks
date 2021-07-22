using System;

namespace NullableExtension
{
    public static class NullableExtensionClass
    {
        public static bool IsNull<T>(this T? value) where T : struct
        {
            return value.HasValue ? false : true;
        }

        public static bool IsNull(this string value)
        {
            return string.IsNullOrEmpty(value);
        }
    }
}
