using System;
using System.Collections.Generic;

namespace Csdsa.DataStructures.ArrayList;

/// <summary>
/// Provides <c>BinarySearch</c> overloads for <see cref="ArrayList{T}"/>.
/// </summary>
public partial class ArrayList<T>
{
    /// <summary>
    /// Searches for the specified element in the entire sorted list using
    /// the default comparer and returns the zero-based index of the element.
    /// </summary>
    /// <param name="item">The element to locate.</param>
    /// <returns>
    /// The zero-based index of <paramref name="item"/> if found; otherwise, a negative number.
    /// </returns>
    public int BinarySearch(T item)
    {
        return BinarySearch(item, Comparer<T>.Default);
    }

    /// <summary>
    /// Searches for the specified element in the entire sorted list using
    /// the specified comparer.
    /// </summary>
    /// <param name="item">The element to locate.</param>
    /// <param name="comparer">
    /// The comparer to use, or <see langword="null"/> to use <see cref="Comparer{T}.Default"/>.
    /// </param>
    /// <returns>
    /// The zero-based index of <paramref name="item"/> if found; otherwise, a negative number.
    /// </returns>
    public int BinarySearch(T item, IComparer<T> comparer)
    {
        comparer ??= Comparer<T>.Default;
        return Array.BinarySearch(_items, 0, _size, item, comparer);
    }

    /// <summary>
    /// Searches a range of elements in the sorted list for the specified element
    /// using the specified comparer.
    /// </summary>
    /// <param name="index">The zero-based starting index of the range to search.</param>
    /// <param name="count">The number of elements in the range to search.</param>
    /// <param name="item">The element to locate.</param>
    /// <param name="comparer">
    /// The comparer to use, or <see langword="null"/> to use <see cref="Comparer{T}.Default"/>.
    /// </param>
    /// <returns>
    /// The zero-based index of <paramref name="item"/> if found; otherwise, a negative number.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="index"/> or <paramref name="count"/> is less than zero.
    /// </exception>
    /// <exception cref="ArgumentException">
    /// Thrown when the range defined by <paramref name="index"/> and <paramref name="count"/>
    /// exceeds the bounds of the list.
    /// </exception>
    public int BinarySearch(int index, int count, T item, IComparer<T> comparer)
    {
        if (index < 0 || count < 0)
        {
            throw new ArgumentOutOfRangeException(index < 0 ? nameof(index) : nameof(count));
        }

        if (_size - index < count)
        {
            throw new ArgumentException("Invalid offset and length.");
        }

        comparer ??= Comparer<T>.Default;
        return Array.BinarySearch(_items, index, count, item, comparer);
    }
}
