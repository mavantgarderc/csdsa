namespace Csdsa.Algorithms.Search.Linear;

public static partial class LinearSearch
{
    /// <summary>
    /// Returns a list of all elements in the sequence that satisfy the specified predicate.
    /// </summary>
    /// <typeparam name="T">The element type of the sequence.</typeparam>
    /// <param name="collection">The sequence to search.</param>
    /// <param name="match">The predicate used to test each element.</param>
    /// <returns>
    /// A read-only list containing all elements that satisfy <paramref name="match"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="collection"/> or <paramref name="match"/> is <see langword="null"/>.
    /// </exception>
    public static IReadOnlyList<T> FindAllMatches<T>(this IEnumerable<T> collection, Func<T, bool> match)
    {
        ArgumentNullException.ThrowIfNull(collection);
        ArgumentNullException.ThrowIfNull(match);

        List<T> result = new List<T>();

        foreach (T item in collection)
        {
            if (match(item))
            {
                result.Add(item);
            }
        }

        return result;
    }
}
