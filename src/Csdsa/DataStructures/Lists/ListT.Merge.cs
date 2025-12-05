namespace Csdsa.DataStructures.Lists;

/// <summary>
/// Provides the <see cref="Merge{T}(IEnumerable{T}, IEnumerable{T})"/> method
/// for combining sequences into a single list-like collection.
/// </summary>
public static partial class ListT
{
    /// <summary>
    /// Merges two sequences into a new list-like collection that contains
    /// all the elements of both inputs.
    /// </summary>
    /// <typeparam name="T">The element type of the sequences.</typeparam>
    /// <param name="first">The first sequence.</param>
    /// <param name="second">The second sequence.</param>
    /// <returns>
    /// A new <see cref="IList{T}"/> containing the elements of <paramref name="first"/>
    /// followed by the elements of <paramref name="second"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="first"/> or <paramref name="second"/> is <see langword="null"/>.
    /// </exception>
    public static IList<T> Merge<T>(IEnumerable<T> first, IEnumerable<T> second)
    {
        if (first == null)
        {
            throw new ArgumentNullException(nameof(first));
        }

        if (second == null)
        {
            throw new ArgumentNullException(nameof(second));
        }

        List<T> result = new List<T>();
        result.AddRange(first);
        result.AddRange(second);
        return result;
    }
}
