namespace Csdsa.DataStructures.Lists;

/// <summary>
/// Provides the <see cref="IndexOf{T}(IList{T}, T)"/> method
/// for locating elements in a list-like collection.
/// </summary>
public static partial class ListT
{
    /// <summary>
    /// Searches for the specified element and returns the zero-based index
    /// of the first occurrence within the list.
    /// </summary>
    /// <typeparam name="T">The element type of the list.</typeparam>
    /// <param name="list">The list to search.</param>
    /// <param name="item">The element to locate.</param>
    /// <returns>
    /// The zero-based index of the first occurrence of <paramref name="item"/>,
    /// if found; otherwise, -1. If <paramref name="list"/> is <see langword="null"/>,
    /// this method also returns -1.
    /// </returns>
    public static int IndexOf<T>(IList<T> list, T item)
    {
        if (list == null)
        {
            return -1;
        }

        return list.IndexOf(item);
    }
}
