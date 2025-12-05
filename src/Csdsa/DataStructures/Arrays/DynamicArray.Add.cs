namespace Csdsa.DataStructures.Arrays;

public partial class DynamicArray<T>
{
    /// <summary>
    /// Adds an element to the end of the dynamic array.
    /// </summary>
    /// <param name="item">The element to add.</param>
    public void Add(T item)
    {
        EnsureCapacity(_count + 1);
        _items[_count++] = item;
    }
}
