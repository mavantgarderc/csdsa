namespace Csdsa.Algorithms.Search.Linear;

public static partial class LinearSearch
{
    /// <summary>
    /// Returns the single element in the sequence that satisfies the specified
    /// predicate, or the default value of <typeparamref name="T"/> if no such
    /// element is found or if more than one matching element exists.
    /// </summary>
    /// <typeparam name="T">The element type of the sequence.</typeparam>
    /// <param name="collection">The sequence to search.</param>
    /// <param name="match">The predicate used to test each element.</param>
    /// <returns>
    /// The single matching element, or <c>default(T)</c> if zero or multiple matches are found.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="collection"/> or <paramref name="match"/> is <see langword="null"/>.
    /// </exception>
    public static T SingleOrDefaultMatch<T>(this IEnumerable<T> collection, Func<T, bool> match)
    {
        ArgumentNullException.ThrowIfNull(collection);
        ArgumentNullException.ThrowIfNull(match);

        T matchItem = default;
        int count = 0;

        foreach (T item in collection)
        {
            if (!match(item))
            {
                continue;
            }

            matchItem = item;
            count++;

            if (count > 1)
            {
                return default;
            }
        }

        return matchItem;
    }
}
