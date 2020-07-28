using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace ES.FX.IO
{
    public static class StreamExtensions
    {
        public static byte[] ToByteArray(this Stream stream)
        {
            if (stream is null) throw new ArgumentNullException(nameof(stream));
            if (stream is MemoryStream directMemoryStream) return directMemoryStream.ToArray();

            using var memoryStream = new MemoryStream();
            stream.CopyTo(memoryStream);
            return memoryStream.ToArray();
        }

        public static async Task<byte[]> ToByteArrayAsync(this Stream stream, CancellationToken cancellationToken = default)
        {
            if (stream is null) throw new ArgumentNullException(nameof(stream));
            if (stream is MemoryStream directMemoryStream) return directMemoryStream.ToArray();

            using var memoryStream = new MemoryStream();
            await stream.CopyToAsync(memoryStream, 81920, cancellationToken);
            return memoryStream.ToArray();
        }
    }
}
