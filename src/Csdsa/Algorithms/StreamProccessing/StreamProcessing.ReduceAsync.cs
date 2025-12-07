namespace Csdsa.Algorithms.StreamProccessing;

public static partial class StreamProcessing
{
    /// <summary>
    /// Asynchronously aggregates the elements of an async sequence using the specified seed value and accumulator function.
    /// </summary>
    /// <typeparam name="T">The element type.</typeparam>
    /// <typeparam name="TAccumulate">The accumulator type.</typeparam>
    /// <param name="source">The async sequence whose elements to aggregate.</param>
    /// <param name="seed">The initial accumulator value.</param>
    /// <param name="func">The accumulator function.</param>
    /// <param name="cancellationToken">The cancellation token used to cancel the asynchronous operation.</param>
    /// <returns>A task that represents the asynchronous aggregation operation.</returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="source"/> or <paramref name="func"/> is <see langword="null"/>.
    /// </exception>
    public static async Task<TAccumulate> ReduceAsync<T, TAccumulate>(
        this IAsyncEnumerable<T> source,
        TAccumulate seed,
        Func<TAccumulate, T, TAccumulate> func,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentNullException.ThrowIfNull(func);

        TAccumulate acc = seed;

        await foreach (T item in source.WithCancellation(cancellationToken))
        {
            acc = func(acc, item);
        }

        return acc;
    }
}
