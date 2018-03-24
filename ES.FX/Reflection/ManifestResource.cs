using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace ES.FX.Reflection
{
    /// <summary>
    ///     Wrapper for a manifest resource embedded in an assembly
    ///     Provides quick access to content and resource properties
    /// </summary>
    public class ManifestResource
    {
        private readonly Assembly _assembly;

        /// <summary>
        ///     Creates a new wrapper for the manifest resource
        /// </summary>
        /// <param name="assembly">Source assembly</param>
        /// <param name="name">Resource name</param>
        public ManifestResource(Assembly assembly, string name)
        {
            Name = name;
            _assembly = assembly;
        }

        /// <summary>
        ///     Gets the resource name
        /// </summary>
        public string Name { get; }


        /// <summary>
        ///     Gets the manifest resource info
        /// </summary>
        public ManifestResourceInfo Info => _assembly.GetManifestResourceInfo(Name);

        /// <summary>
        ///     Returns the stream for the manifest resource
        /// </summary>
        public Stream GetStream()
        {
            return _assembly.GetManifestResourceStream(Name);
        }


        /// <summary>
        ///     Returns manifest resource content as text
        /// </summary>
        public string ReadText()
        {
            using (var reader = GetStreamReader())
            {
                return reader.ReadToEnd();
            }
        }

        /// <summary>
        ///     Returns manifest resource content as text
        /// </summary>
        public Task<string> ReadTextAsync()
        {
            using (var reader = GetStreamReader())
            {
                return reader.ReadToEndAsync();
            }
        }

        /// <summary>
        ///     Returns a <see cref="StreamReader"></see> initialized with the manifest resource content <see cref="Stream" />
        /// </summary>
        public StreamReader GetStreamReader()
        {
            return new StreamReader(GetStream());
        }

        public override string ToString()
        {
            return Name ?? base.ToString();
        }
    }
}