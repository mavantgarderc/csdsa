namespace Csdsa.DataStructures.ArrayList;

public partial class ArrayListUtils<T>
{
    /// <summary>
    /// Adds an element to the end of the list.
    /// </summary>
    /// <param name="item">The element to add.</param>
    public void Add(T item)
    {
        if (_size == _items.Length)
        {
            EnsureCapacity(_size + 1);
        }

        _items[_size++] = item;
        _version++;
    }
}
