namespace Csdsa.Algorithms.StreamProccessing;

public static partial class StreamProcessing
{
    /// <summary>
    /// Splits the source sequence into contiguous chunks of the specified size.
    /// </summary>
    /// <typeparam name="T">The element type.</typeparam>
    /// <param name="source">The source sequence.</param>
    /// <param name="chunkSize">The size of each chunk. Must be positive.</param>
    /// <returns>An <see cref="IEnumerable{T}"/> of chunks, each chunk represented as a <see cref="List{T}"/>.</returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="source"/> is <see langword="null"/>.
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="chunkSize"/> is less than or equal to zero.
    /// </exception>
    public static IEnumerable<List<T>> Chunk<T>(
        this IEnumerable<T> source,
        int chunkSize)
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(chunkSize);

        List<T> buffer = new List<T>(chunkSize);

        foreach (T item in source)
        {
            buffer.Add(item);

            if (buffer.Count == chunkSize)
            {
                yield return new List<T>(buffer);
                buffer.Clear();
            }
        }

        if (buffer.Count > 0)
        {
            yield return buffer;
        }
    }
}
