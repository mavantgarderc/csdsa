namespace Csdsa.Algorithms.StreamProccessing;

public static partial class StreamProcessing
{
    /// <summary>
    /// Bypasses a specified number of elements in a sequence and then returns the remaining elements.
    /// </summary>
    /// <typeparam name="T">The element type.</typeparam>
    /// <param name="source">An <see cref="IEnumerable{T}"/> to return elements from.</param>
    /// <param name="count">The number of elements to skip.</param>
    /// <returns>An <see cref="IEnumerable{T}"/> that contains the elements that occur after the specified index.</returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="source"/> is <see langword="null"/>.
    /// </exception>
    public static IEnumerable<T> Skip<T>(this IEnumerable<T> source, int count)
    {
        ArgumentNullException.ThrowIfNull(source);

        int i = 0;

        foreach (T item in source)
        {
            if (i++ >= count)
            {
                yield return item;
            }
        }
    }
}
