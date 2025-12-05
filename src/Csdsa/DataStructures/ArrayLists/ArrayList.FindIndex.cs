using System;
using System.Collections.Generic;

namespace Csdsa.DataStructures.ArrayList;

/// <summary>
/// Provides <c>FindIndex</c> overloads for <see cref="ArrayList{T}"/>.
/// </summary>
public partial class ArrayList<T>
{
    /// <summary>
    /// Searches for an element that matches the conditions defined by the specified
    /// predicate, and returns the zero-based index of the first occurrence.
    /// </summary>
    /// <param name="match">The predicate to test elements.</param>
    /// <returns>
    /// The zero-based index of the first element that matches the predicate,
    /// if found; otherwise, -1.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="match"/> is <see langword="null"/>.
    /// </exception>
    public int FindIndex(Predicate<T> match)
    {
        return FindIndex(0, _size, match);
    }

    /// <summary>
    /// Searches for an element that matches the conditions defined by the specified
    /// predicate, starting at the specified index, and returns the zero-based index
    /// of the first occurrence.
    /// </summary>
    /// <param name="startIndex">The zero-based starting index of the search.</param>
    /// <param name="match">The predicate to test elements.</param>
    /// <returns>
    /// The zero-based index of the first element that matches the predicate,
    /// if found; otherwise, -1.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="match"/> is <see langword="null"/>.
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="startIndex"/> is outside the range of valid indices.
    /// </exception>
    public int FindIndex(int startIndex, Predicate<T> match)
    {
        return FindIndex(startIndex, _size - startIndex, match);
    }

    /// <summary>
    /// Searches for an element that matches the conditions defined by the specified
    /// predicate within the specified range, and returns the zero-based index
    /// of the first occurrence.
    /// </summary>
    /// <param name="startIndex">The zero-based starting index of the search.</param>
    /// <param name="count">The number of elements in the range to search.</param>
    /// <param name="match">The predicate to test elements.</param>
    /// <returns>
    /// The zero-based index of the first element that matches the predicate,
    /// if found; otherwise, -1.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="match"/> is <see langword="null"/>.
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="startIndex"/> or <paramref name="count"/> is invalid.
    /// </exception>
    public int FindIndex(int startIndex, int count, Predicate<T> match)
    {
        ArgumentNullException.ThrowIfNull(match);

        if (startIndex < 0 || startIndex > _size)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (count < 0 || startIndex > _size - count)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endIndex = startIndex + count;
        for (int i = startIndex; i < endIndex; i++)
        {
            if (match(_items[i]))
            {
                return i;
            }
        }

        return -1;
    }
}
