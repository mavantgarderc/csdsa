namespace Csdsa.Algorithms.Search.Linear;

public static partial class LinearSearch
{
    /// <summary>
    /// Returns a list of all elements in the sequence that satisfy the specified predicate.
    /// This is an alias for <see cref="FindAllMatches{T}(IEnumerable{T}, Func{T, bool})"/>.
    /// </summary>
    /// <typeparam name="T">The element type of the sequence.</typeparam>
    /// <param name="collection">The sequence to search.</param>
    /// <param name="match">The predicate used to test each element.</param>
    /// <returns>
    /// A read-only list containing all elements that satisfy <paramref name="match"/>.
    /// </returns>
    public static IReadOnlyList<T> FindAll<T>(this IEnumerable<T> collection, Func<T, bool> match)
    {
        return FindAllMatches(collection, match);
    }
}
