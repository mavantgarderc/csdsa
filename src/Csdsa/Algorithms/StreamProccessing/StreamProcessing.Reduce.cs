namespace Csdsa.Algorithms.StreamProccessing;

public static partial class StreamProcessing
{
    /// <summary>
    /// Aggregates the elements of a sequence using the specified seed value and accumulator function.
    /// </summary>
    /// <typeparam name="T">The element type.</typeparam>
    /// <typeparam name="TAccumulate">The accumulator type.</typeparam>
    /// <param name="source">The source sequence.</param>
    /// <param name="seed">The initial accumulator value.</param>
    /// <param name="func">The accumulator function.</param>
    /// <returns>The final accumulator value.</returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="source"/> or <paramref name="func"/> is <see langword="null"/>.
    /// </exception>
    public static TAccumulate Reduce<T, TAccumulate>(
        this IEnumerable<T> source,
        TAccumulate seed,
        Func<TAccumulate, T, TAccumulate> func)
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentNullException.ThrowIfNull(func);

        TAccumulate acc = seed;

        foreach (T item in source)
        {
            acc = func(acc, item);
        }

        return acc;
    }
}
