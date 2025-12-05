namespace Csdsa.DataStructures.Lists;

/// <summary>
/// Provides the <see cref="SortDescending{T}(IList{T})"/> method
/// for sorting lists in descending order.
/// </summary>
public static partial class ListT
{
    /// <summary>
    /// Sorts the elements in the specified list in descending order
    /// using the default comparer.
    /// </summary>
    /// <typeparam name="T">
    /// The element type of the list, which must implement <see cref="IComparable{T}"/>.
    /// </typeparam>
    /// <param name="list">The list to sort.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="list"/> is <see langword="null"/>.
    /// </exception>
    public static void SortDescending<T>(IList<T> list)
        where T : IComparable<T>
    {
        if (list == null)
        {
            throw new ArgumentNullException(nameof(list));
        }

        if (list is List<T> concrete)
        {
            concrete.Sort((a, b) => b.CompareTo(a));
            return;
        }

        List<T> buffer = new List<T>(list);
        buffer.Sort((a, b) => b.CompareTo(a));

        for (int i = 0; i < buffer.Count; i++)
        {
            list[i] = buffer[i];
        }
    }
}
