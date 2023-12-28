using System;
using System.Diagnostics.CodeAnalysis;

namespace UnityHelpers
{
    public static class AssertionExtensions
    {
        [return: NotNull]
        public static T NotNull<T>([AllowNull] this T parameter, string name) where T : class
        {
            if (parameter == null)
            {
                throw new ArgumentNullException(name);
            }

            return parameter;
        }
    }
}