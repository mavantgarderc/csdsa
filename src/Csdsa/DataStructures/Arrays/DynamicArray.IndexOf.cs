namespace Csdsa.DataStructures.Arrays;

public partial class DynamicArray<T>
{
    /// <summary>
    /// Searches for the specified element and returns the zero-based index
    /// of its first occurrence within the dynamic array.
    /// </summary>
    /// <param name="item">The element to locate.</param>
    /// <returns>
    /// The zero-based index of the first occurrence of <paramref name="item"/>,
    /// if found; otherwise, -1.
    /// </returns>
    public int IndexOf(T item)
    {
        for (int i = 0; i < _count; i++)
        {
            if (Equals(_items[i], item))
            {
                return i;
            }
        }

        return -1;
    }
}
