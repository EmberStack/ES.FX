using System.Collections.Generic;
using System.Linq;
using ES.FX.Static;

namespace ES.FX.Linq
{
    /// <summary>
    ///     Linq extensions for <see cref="IList{T}"></see> collection
    /// </summary>
    public static class ListExtensions
    {
        /// <summary>
        ///     Returns a random item in an <see cref="IList{T}"></see> collection or the default value
        /// </summary>
        /// <param name="list">List of items to pick from</param>
        public static T RandomOrDefault<T>(this IList<T> list)
        {
            return list.Any() ? list[StaticRandom.Instance.Next(0, list.Count)] : default(T);
        }
    }
}