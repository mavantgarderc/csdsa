namespace Csdsa.DataStructures.Lists;

/// <summary>
/// Provides the <see cref="Reverse{T}(IList{T})"/> method
/// for reversing list-like collections.
/// </summary>
public static partial class ListT
{
    /// <summary>
    /// Reverses the order of the elements in the specified list.
    /// </summary>
    /// <typeparam name="T">The element type of the list.</typeparam>
    /// <param name="list">The list whose elements to reverse.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="list"/> is <see langword="null"/>.
    /// </exception>
    public static void Reverse<T>(IList<T> list)
    {
        if (list == null)
        {
            throw new ArgumentNullException(nameof(list));
        }

        if (list is List<T> concrete)
        {
            concrete.Reverse();
            return;
        }

        int i = 0;
        int j = list.Count - 1;

        while (i < j)
        {
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
            i++;
            j--;
        }
    }
}
