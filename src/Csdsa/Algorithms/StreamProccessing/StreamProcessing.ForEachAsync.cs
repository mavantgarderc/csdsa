namespace Csdsa.Algorithms.StreamProccessing;

public static partial class StreamProcessing
{
    /// <summary>
    /// Asynchronously performs the specified action on each element of an async sequence.
    /// </summary>
    /// <typeparam name="T">The element type of the async sequence.</typeparam>
    /// <param name="source">The async sequence whose elements to process.</param>
    /// <param name="action">The action to perform on each element.</param>
    /// <param name="cancellationToken">The cancellation token used to cancel the asynchronous operation.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="source"/> or <paramref name="action"/> is <see langword="null"/>.
    /// </exception>
    public static async Task ForEachAsync<T>(
        this IAsyncEnumerable<T> source,
        Action<T> action,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentNullException.ThrowIfNull(action);

        await foreach (T item in source.WithCancellation(cancellationToken))
        {
            action(item);
        }
    }
}
