namespace Csdsa.DataStructures.Arrays;

public partial class DynamicArray<T>
{
    /// <summary>
    /// Inserts an element into the dynamic array at the specified index.
    /// </summary>
    /// <param name="index">
    /// The zero-based index at which <paramref name="item"/> should be inserted.
    /// </param>
    /// <param name="item">The element to insert.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="index"/> is less than zero or greater than
    /// <see cref="Count"/>.
    /// </exception>
    public void Insert(int index, T item)
    {
        if (index < 0 || index > _count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        EnsureCapacity(_count + 1);
        Array.Copy(_items, index, _items, index + 1, _count - index);
        _items[index] = item;
        _count++;
    }
}
