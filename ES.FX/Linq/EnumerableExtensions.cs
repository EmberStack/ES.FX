using System;
using System.Collections.Generic;
using System.Linq;

namespace ES.FX.Linq
{
    public static class EnumerableExtensions
    {
        /// <summary>Returns a specified number of contiguous elements from the start of a sequence with a maximum count of <see cref="max"/>.</summary>
        /// <param name="source">The sequence to return elements from.</param>
        /// <param name="max">The maximum number of elements to return.</param>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <returns>An <see cref="System.Collections.Generic.IEnumerable{TSource}"></see> that contains the specified number of elements from the start of the input sequence.</returns>
        public static IEnumerable<TSource> TakeUpto<TSource>(this IEnumerable<TSource> source, int max)
        {
            var enumerable = source?.ToList();
            return enumerable?.Take(Math.Min(enumerable.Count(), max));
        }
    }
}