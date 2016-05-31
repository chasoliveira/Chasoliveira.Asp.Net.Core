using System;
using System.Collections.Generic;

namespace Chasoliveira.Core.Common.Extensions
{
    public static class ExpressionExtensions
    {
        public static int ForEach<T>(this IEnumerable<T> list, Action<int, T> action)
        {
            if (action == null) throw new ArgumentNullException(nameof(action));

            var index = 0;

            foreach (var elem in list)
                action(index++, elem);

            return index;
        }

        public static void ForEach<T>(this IEnumerable<T> list, Action<T> action)
        {
            if (action == null) throw new ArgumentNullException(nameof(action));

            foreach (var elem in list)
                action(elem);
        }
    }
}
