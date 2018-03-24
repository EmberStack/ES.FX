using System.Linq;
using System.Reflection;

namespace ES.FX.Reflection
{
    /// <summary>
    ///     Extension methods for <see cref="ManifestResource"></see>
    /// </summary>
    public static class ManifestResourceExtensions
    {
        /// <summary>
        ///     Gets the <see cref="ManifestResource"></see> wrappers for embedded assembly resources
        /// </summary>
        /// <param name="assembly">Source assembly</param>
        /// <returns></returns>
        public static ManifestResource[] GetManifestResources(this Assembly assembly)
        {
            var targetAssembly = assembly ?? Assembly.GetCallingAssembly();
            return targetAssembly.GetManifestResourceNames()
                .Select(resource => new ManifestResource(targetAssembly, resource))
                .ToArray();
        }
    }
}