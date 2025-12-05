namespace Csdsa.DataStructures.ArrayList;

public partial class ArrayListUtils<T>
{
    /// <summary>
    /// Reverses the order of the elements in the entire list.
    /// </summary>
    public void Reverse()
    {
        Array.Reverse(_items, 0, _size);
    }

    /// <summary>
    /// Reverses the order of the elements in the specified range of the list.
    /// </summary>
    /// <param name="index">The zero-based starting index of the range to reverse.</param>
    /// <param name="count">The number of elements in the range to reverse.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="index"/> or <paramref name="count"/> is less than zero.
    /// </exception>
    /// <exception cref="ArgumentException">
    /// Thrown when the range defined by <paramref name="index"/> and <paramref name="count"/>
    /// exceeds the bounds of the list.
    /// </exception>
    public void Reverse(int index, int count)
    {
        if (index < 0 || count < 0)
        {
            throw new ArgumentOutOfRangeException(index < 0 ? nameof(index) : nameof(count));
        }

        if (_size - index < count)
        {
            throw new ArgumentException("Invalid offset and length.");
        }

        Array.Reverse(_items, index, count);
        _version++;
    }
}
