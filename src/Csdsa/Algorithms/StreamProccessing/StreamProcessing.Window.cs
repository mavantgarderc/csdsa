namespace Csdsa.Algorithms.StreamProccessing;

public static partial class StreamProcessing
{
    /// <summary>
    /// Batches the source sequence into windows of the specified size.
    /// </summary>
    /// <typeparam name="T">The element type of the sequence.</typeparam>
    /// <param name="source">The source sequence.</param>
    /// <param name="windowSize">The size of each window. Must be positive.</param>
    /// <returns>An <see cref="IEnumerable{T}"/> of windows, each represented as a <see cref="List{T}"/>.</returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="source"/> is <see langword="null"/>.
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="windowSize"/> is less than or equal to zero.
    /// </exception>
    public static IEnumerable<List<T>> Window<T>(
        this IEnumerable<T> source,
        int windowSize)
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(windowSize);

        List<T> buffer = new List<T>(windowSize);

        foreach (T item in source)
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
            yield return new List<T>(buffer);
        }
    }
}
