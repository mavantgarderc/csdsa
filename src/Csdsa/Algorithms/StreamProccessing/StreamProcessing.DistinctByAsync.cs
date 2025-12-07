using System.Runtime.CompilerServices;

namespace Csdsa.Algorithms.StreamProccessing;

public static partial class StreamProcessing
{
    /// <summary>
    /// Asynchronously returns distinct elements from an async sequence by using a specified key selector.
    /// </summary>
    /// <typeparam name="T">The element type of the async sequence.</typeparam>
    /// <typeparam name="TKey">The type of the key returned by the selector.</typeparam>
    /// <param name="source">The async sequence to remove duplicate elements from.</param>
    /// <param name="keySelector">A function to extract the key for each element.</param>
    /// <param name="cancellationToken">The cancellation token used to cancel the asynchronous operation.</param>
    /// <returns>
    /// An async sequence that contains distinct elements from the source sequence.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="source"/> or <paramref name="keySelector"/> is <see langword="null"/>.
    /// </exception>
    public static async IAsyncEnumerable<T> DistinctByAsync<T, TKey>(
        this IAsyncEnumerable<T> source,
        Func<T, TKey> keySelector,
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentNullException.ThrowIfNull(keySelector);

        HashSet<TKey> seen = new HashSet<TKey>();

        await foreach (T item in source.WithCancellation(cancellationToken))
        {
            if (seen.Add(keySelector(item)))
            {
                yield return item;
            }
        }
    }
}
