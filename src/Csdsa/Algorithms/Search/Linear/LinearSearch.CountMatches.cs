namespace Csdsa.Algorithms.Search.Linear;

public static partial class LinearSearch
{
    /// <summary>
    /// Counts the number of elements in the sequence that satisfy the specified predicate.
    /// </summary>
    /// <typeparam name="T">The element type of the sequence.</typeparam>
    /// <param name="collection">The sequence to search.</param>
    /// <param name="match">The predicate used to test each element.</param>
    /// <returns>The number of elements satisfying <paramref name="match"/>.</returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="collection"/> or <paramref name="match"/> is <see langword="null"/>.
    /// </exception>
    public static int CountMatches<T>(this IEnumerable<T> collection, Func<T, bool> match)
    {
        ArgumentNullException.ThrowIfNull(collection);
        ArgumentNullException.ThrowIfNull(match);

        int count = 0;

        foreach (T item in collection)
        {
            if (match(item))
            {
                count++;
            }
        }

        return count;
    }
}
