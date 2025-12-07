using System.Runtime.CompilerServices;

namespace Csdsa.Algorithms.StreamProccessing;

public static partial class StreamProcessing
{
    /// <summary>
    /// Asynchronously returns elements from an async sequence until the specified predicate is satisfied,
    /// including the element that satisfies the predicate.
    /// </summary>
    /// <typeparam name="T">The element type of the async sequence.</typeparam>
    /// <param name="source">The async sequence to return elements from.</param>
    /// <param name="predicate">A function to test each element for a stop condition.</param>
    /// <param name="cancellationToken">The cancellation token used to cancel the asynchronous operation.</param>
    /// <returns>
    /// An async sequence that returns elements from the input sequence until the predicate is satisfied.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="source"/> or <paramref name="predicate"/> is <see langword="null"/>.
    /// </exception>
    public static async IAsyncEnumerable<T> TakeUntilAsync<T>(
        this IAsyncEnumerable<T> source,
        Func<T, bool> predicate,
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentNullException.ThrowIfNull(predicate);

        await foreach (T item in source.WithCancellation(cancellationToken))
        {
            yield return item;

            if (predicate(item))
            {
                yield break;
            }
        }
    }
}
