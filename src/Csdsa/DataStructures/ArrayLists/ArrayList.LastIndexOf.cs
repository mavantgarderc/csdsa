using System;

namespace Csdsa.DataStructures.ArrayList;

/// <summary>
/// Provides <c>LastIndexOf</c> overloads for <see cref="ArrayList{T}"/>.
/// </summary>
public partial class ArrayList<T>
{
    /// <summary>
    /// Returns the zero-based index of the last occurrence of a value in the entire list.
    /// </summary>
    /// <param name="item">The element to locate.</param>
    /// <returns>
    /// The zero-based index of the last occurrence of <paramref name="item"/>, if found;
    /// otherwise, -1.
    /// </returns>
    public int LastIndexOf(T item)
    {
        return LastIndexOf(item, _size - 1, _size);
    }

    /// <summary>
    /// Returns the zero-based index of the last occurrence of a value in the list,
    /// searching backward from the specified index.
    /// </summary>
    /// <param name="item">The element to locate.</param>
    /// <param name="startIndex">
    /// The zero-based starting index of the backward search.
    /// </param>
    /// <returns>
    /// The zero-based index of the last occurrence of <paramref name="item"/>, if found;
    /// otherwise, -1.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="startIndex"/> is outside the bounds of the list.
    /// </exception>
    public int LastIndexOf(T item, int startIndex)
    {
        return LastIndexOf(item, startIndex, startIndex + 1);
    }

    /// <summary>
    /// Returns the zero-based index of the last occurrence of a value in a range of
    /// elements in the list.
    /// </summary>
    /// <param name="item">The element to locate.</param>
    /// <param name="startIndex">
    /// The zero-based starting index of the backward search.
    /// </param>
    /// <param name="count">The number of elements in the section to search.</param>
    /// <returns>
    /// The zero-based index of the last occurrence of <paramref name="item"/>, if found;
    /// otherwise, -1.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="startIndex"/> or <paramref name="count"/> is out of range.
    /// </exception>
    public int LastIndexOf(T item, int startIndex, int count)
    {
        if (_size == 0)
        {
            return -1;
        }

        if (startIndex < 0 || startIndex >= _size)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (count < 0 || startIndex - count + 1 < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        return Array.LastIndexOf(_items, item, startIndex, count);
    }
}
