namespace Csdsa.Algorithms.Search.Linear;

public static partial class LinearSearch
{
    /// <summary>
    /// Returns the zero-based index of the last element in the sequence that
    /// satisfies the specified predicate, or -1 if no such element exists.
    /// </summary>
    /// <typeparam name="T">The element type of the sequence.</typeparam>
    /// <param name="collection">The sequence to search.</param>
    /// <param name="match">The predicate used to test each element.</param>
    /// <returns>
    /// The zero-based index of the last matching element, or -1 if no match is found.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="collection"/> or <paramref name="match"/> is <see langword="null"/>.
    /// </exception>
    public static int LastIndexOf<T>(this IEnumerable<T> collection, Func<T, bool> match)
    {
        ArgumentNullException.ThrowIfNull(collection);
        ArgumentNullException.ThrowIfNull(match);

        int lastIndex = -1;
        int index = 0;

        foreach (T item in collection)
        {
            if (match(item))
            {
                lastIndex = index;
            }

            index++;
        }

        return lastIndex;
    }
}
