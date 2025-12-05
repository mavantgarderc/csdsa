namespace Csdsa.DataStructures.ArrayList;

/// <summary>
/// Provides the <see cref="Remove(T)"/> method for <see cref="ArrayList{T}"/>.
/// </summary>
public partial class ArrayList<T>
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
