﻿namespace Aura.Extensions
{
    public static class ObjectExtensions
    {
        public static string ToStringNullSafe(this object value)
        {
            return (value ?? string.Empty).ToString();
        }
    }
}
