namespace Csdsa.Algorithms.StreamProccessing;

public static partial class StreamProcessing
{
    /// <summary>
    /// Returns a specified number of contiguous elements from the start of a sequence.
    /// </summary>
    /// <typeparam name="T">The element type.</typeparam>
    /// <param name="source">The sequence to return elements from.</param>
    /// <param name="count">The number of elements to return.</param>
    /// <returns>An <see cref="IEnumerable{T}"/> that contains the specified number of elements.</returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="source"/> is <see langword="null"/>.
    /// </exception>
    public static IEnumerable<T> Take<T>(this IEnumerable<T> source, int count)
    {
        ArgumentNullException.ThrowIfNull(source);

        int i = 0;

        foreach (T item in source)
        {
            if (i++ >= count)
            {
                yield break;
            }

            yield return item;
        }
    }
}
