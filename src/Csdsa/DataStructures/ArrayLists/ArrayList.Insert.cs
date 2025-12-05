namespace Csdsa.DataStructures.ArrayList;

public partial class ArrayListUtils<T>
{
    /// <summary>
    /// Inserts an element into the list at the specified index.
    /// </summary>
    /// <param name="index">The zero-based index at which the element should be inserted.</param>
    /// <param name="item">The element to insert.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="index"/> is less than zero or greater than <see cref="Count"/>.
    /// </exception>
    public void Insert(int index, T item)
    {
        if ((uint)index > (uint)_size)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (_size == _items.Length)
        {
            EnsureCapacity(_size + 1);
        }

        if (index < _size)
        {
            Array.Copy(_items, index, _items, index + 1, _size - index);
        }

        _items[index] = item;
        _size++;
        _version++;
    }
}
