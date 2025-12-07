namespace Csdsa.Algorithms.StreamProccessing;

public static partial class StreamProcessing
{
    /// <summary>
    /// Returns elements from the sequence until the specified predicate evaluates to true,
    /// including the element that satisfies the predicate.
    /// </summary>
    /// <typeparam name="T">The element type of the sequence.</typeparam>
    /// <param name="source">The source sequence.</param>
    /// <param name="predicate">A function to test each element for a stop condition.</param>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> that returns elements from the input sequence
    /// until the predicate is satisfied.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="source"/> or <paramref name="predicate"/> is <see langword="null"/>.
    /// </exception>
    public static IEnumerable<T> TakeUntil<T>(
        this IEnumerable<T> source,
        Func<T, bool> predicate)
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentNullException.ThrowIfNull(predicate);

        foreach (T item in source)
        {
            yield return item;

            if (predicate(item))
            {
                yield break;
            }
        }
    }
}
