namespace Csdsa.DataStructures.Lists;

/// <summary>
/// Provides the <see cref="Clone{T}(IEnumerable{T})"/> method
/// for cloning sequences into list-backed collections.
/// </summary>
public static partial class ListT
{
    /// <summary>
    /// Creates a new list-like collection that contains the same elements as the specified source.
    /// </summary>
    /// <typeparam name="T">The element type of the sequence.</typeparam>
    /// <param name="source">The sequence to clone.</param>
    /// <returns>
    /// A new <see cref="IList{T}"/> containing the elements of <paramref name="source"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="source"/> is <see langword="null"/>.
    /// </exception>
    public static IList<T> Clone<T>(IEnumerable<T> source)
    {
        if (source == null)
        {
            throw new ArgumentNullException(nameof(source));
        }

        return new List<T>(source);
    }
}
