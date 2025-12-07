namespace Csdsa.Algorithms.Search.Linear;

public static partial class LinearSearch
{
    /// <summary>
    /// Removes all elements from the list that satisfy the specified predicate
    /// and returns the number of removed elements.
    /// </summary>
    /// <typeparam name="T">The element type of the list.</typeparam>
    /// <param name="collection">The list to modify.</param>
    /// <param name="match">The predicate used to test each element.</param>
    /// <returns>The number of elements removed from <paramref name="collection"/>.</returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="collection"/> or <paramref name="match"/> is <see langword="null"/>.
    /// </exception>
    public static int RemoveAllMatches<T>(this List<T> collection, Func<T, bool> match)
    {
        ArgumentNullException.ThrowIfNull(collection);
        ArgumentNullException.ThrowIfNull(match);

        int removed = 0;

        for (int i = collection.Count - 1; i >= 0; i--)
        {
            if (match(collection[i]))
            {
                collection.RemoveAt(i);
                removed++;
            }
        }

        return removed;
    }
}
