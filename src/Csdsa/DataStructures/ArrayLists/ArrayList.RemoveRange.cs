using System;

namespace Csdsa.DataStructures.ArrayList;

/// <summary>
/// Provides the <see cref="RemoveRange(int, int)"/> method
/// for <see cref="ArrayList{T}"/>.
/// </summary>
public partial class ArrayList<T>
{
    /// <summary>
    /// Removes a range of elements from the list.
    /// </summary>
    /// <param name="startIndex">The zero-based starting index of the range to remove.</param>
    /// <param name="count">The number of elements to remove.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="startIndex"/> or <paramref name="count"/> is less than zero.
    /// </exception>
    /// <exception cref="ArgumentException">
    /// Thrown when the range defined by <paramref name="startIndex"/> and <paramref name="count"/>
    /// exceeds the bounds of the list.
    /// </exception>
    public void RemoveRange(int startIndex, int count)
    {
        if (startIndex < 0 || count < 0)
        {
            throw new ArgumentOutOfRangeException(
                startIndex < 0 ? nameof(startIndex) : nameof(count));
        }

        if (_size - startIndex < count)
        {
            throw new ArgumentException("Invalid offset and length.");
        }

        if (count > 0)
        {
            int newSize = _size - count;

            if (startIndex < newSize)
            {
                Array.Copy(_items, startIndex + count, _items, startIndex, newSize - startIndex);
            }

            Array.Clear(_items, newSize, count);
            _size = newSize;
            _version++;
        }
    }
}
