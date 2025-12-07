using System.Runtime.CompilerServices;

namespace Csdsa.Algorithms.StreamProccessing;

public static partial class StreamProcessing
{
    /// <summary>
    /// Asynchronously bypasses a specified number of elements in an async sequence
    /// and then returns the remaining elements.
    /// </summary>
    /// <typeparam name="T">The element type of the async sequence.</typeparam>
    /// <param name="source">The async sequence to skip elements from.</param>
    /// <param name="count">The number of elements to skip.</param>
    /// <param name="cancellationToken">The cancellation token used to cancel the asynchronous operation.</param>
    /// <returns>An async sequence that contains the elements after the skipped elements.</returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="source"/> is <see langword="null"/>.
    /// </exception>
    public static async IAsyncEnumerable<T> SkipAsync<T>(
        this IAsyncEnumerable<T> source,
        int count,
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(source);

        int i = 0;

        await foreach (T item in source.WithCancellation(cancellationToken))
        {
            if (i++ >= count)
            {
                yield return item;
            }
        }
    }
}
