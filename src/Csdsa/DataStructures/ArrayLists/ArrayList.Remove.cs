namespace Csdsa.DataStructures.ArrayList;

public partial class ArrayListUtils<T>
{
    /// <summary>
    /// Removes the first occurrence of a specific object from the list.
    /// </summary>
    /// <param name="item">The element to remove.</param>
    /// <returns>
    /// <see langword="true"/> if <paramref name="item"/> is successfully removed;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    public bool Remove(T item)
    {
        int index = IndexOf(item);

        if (index >= 0)
        {
            RemoveAt(index);
            return true;
        }

        return false;
    }
}
