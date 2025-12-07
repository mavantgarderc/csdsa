using System.Runtime.CompilerServices;

namespace Csdsa.Algorithms.StreamProccessing;

public static partial class StreamProcessing
{
    /// <summary>
    /// Asynchronously splits an async sequence into contiguous chunks of the specified size.
    /// </summary>
    /// <typeparam name="T">The element type of the async sequence.</typeparam>
    /// <param name="source">The async sequence to split into chunks.</param>
    /// <param name="chunkSize">The size of each chunk. Must be positive.</param>
    /// <param name="cancellationToken">The cancellation token used to cancel the asynchronous operation.</param>
    /// <returns>
    /// An async sequence of chunks, each represented as a <see cref="List{T}"/>,
    /// containing up to <paramref name="chunkSize"/> elements.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="source"/> is <see langword="null"/>.
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="chunkSize"/> is less than or equal to zero.
    /// </exception>
    public static async IAsyncEnumerable<List<T>> ChunkAsync<T>(
        this IAsyncEnumerable<T> source,
        int chunkSize,
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(chunkSize);

        List<T> buffer = new List<T>(chunkSize);

        await foreach (T item in source.WithCancellation(cancellationToken))
        {
            buffer.Add(item);

            if (buffer.Count == chunkSize)
            {
                yield return new List<T>(buffer);
                buffer.Clear();
            }
        }

        if (buffer.Count > 0)
        {
            yield return buffer;
        }
    }
}
