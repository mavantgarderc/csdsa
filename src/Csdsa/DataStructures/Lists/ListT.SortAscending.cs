namespace Csdsa.DataStructures.Lists;

/// <summary>
/// Provides the <see cref="SortAscending{T}(IList{T})"/> method
/// for sorting lists in ascending order.
/// </summary>
public static partial class ListT
{
    /// <summary>
    /// Sorts the elements in the specified list in ascending order using the default comparer.
    /// </summary>
    /// <typeparam name="T">
    /// The element type of the list, which must implement <see cref="IComparable{T}"/>.
    /// </typeparam>
    /// <param name="list">The list to sort.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="list"/> is <see langword="null"/>.
    /// </exception>
    public static void SortAscending<T>(IList<T> list)
        where T : IComparable<T>
    {
        if (list == null)
        {
            throw new ArgumentNullException(nameof(list));
        }

        if (list is List<T> concrete)
        {
            concrete.Sort();
            return;
        }

        List<T> buffer = new List<T>(list);
        buffer.Sort();

        for (int i = 0; i < buffer.Count; i++)
        {
            list[i] = buffer[i];
        }
    }
}
