using System.Runtime.CompilerServices;

namespace Csdsa.Algorithms.StreamProccessing;

public static partial class StreamProcessing
{
    /// <summary>
    /// Asynchronously batches an async sequence into windows of the specified size.
    /// </summary>
    /// <typeparam name="T">The element type of the async sequence.</typeparam>
    /// <param name="source">The async sequence to batch.</param>
    /// <param name="windowSize">The size of each window. Must be positive.</param>
    /// <param name="cancellationToken">The cancellation token used to cancel the asynchronous operation.</param>
    /// <returns>
    /// An async sequence of windows, each represented as a <see cref="List{T}"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="source"/> is <see langword="null"/>.
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="windowSize"/> is less than or equal to zero.
    /// </exception>
    public static async IAsyncEnumerable<List<T>> WindowAsync<T>(
        this IAsyncEnumerable<T> source,
        int windowSize,
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(windowSize);

        List<T> buffer = new List<T>(windowSize);

        await foreach (T item in source.WithCancellation(cancellationToken))
        {
            buffer.Add(item);

            if (buffer.Count == windowSize)
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
