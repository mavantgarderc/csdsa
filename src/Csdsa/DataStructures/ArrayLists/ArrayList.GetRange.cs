using System;

namespace Csdsa.DataStructures.ArrayList;

/// <summary>
/// Provides the <see cref="GetRange(int, int)"/> method for <see cref="ArrayList{T}"/>.
/// </summary>
public partial class ArrayList<T>
{
    /// <summary>
    /// Creates a shallow copy of a range of elements in the list.
    /// </summary>
    /// <param name="startIndex">The zero-based starting index of the range.</param>
    /// <param name="count">The number of elements in the range.</param>
    /// <returns>
    /// A new <see cref="ArrayList{T}"/> containing the specified range of elements.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="startIndex"/> or <paramref name="count"/> is less than zero.
    /// </exception>
    /// <exception cref="ArgumentException">
    /// Thrown when the range defined by <paramref name="startIndex"/> and <paramref name="count"/>
    /// exceeds the bounds of the list.
    /// </exception>
    public ArrayList<T> GetRange(int startIndex, int count)
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

        ArrayList<T> list = new ArrayList<T>(count);

        if (count > 0)
        {
            Array.Copy(_items, startIndex, list._items, 0, count);
            list._size = count;
        }

        return list;
    }
}
