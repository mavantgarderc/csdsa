using System;
using System.Collections.Generic;

namespace Csdsa.DataStructures.ArrayList;

/// <summary>
/// Provides the <see cref="InsertRange(int, IEnumerable{T})"/> method
/// for <see cref="ArrayList{T}"/>.
/// </summary>
public partial class ArrayList<T>
{
    /// <summary>
    /// Inserts the elements of a collection into the list at the specified index.
    /// </summary>
    /// <param name="index">The zero-based index at which to insert the new elements.</param>
    /// <param name="collection">The collection whose elements should be inserted.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="collection"/> is <see langword="null"/>.
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="index"/> is less than zero or greater than <see cref="Count"/>.
    /// </exception>
    public void InsertRange(int index, IEnumerable<T> collection)
    {
        ArgumentNullException.ThrowIfNull(collection);

        if ((uint)index > (uint)_size)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (collection is ICollection<T> col)
        {
            int count = col.Count;

            if (count > 0)
            {
                EnsureCapacity(_size + count);

                if (index < _size)
                {
                    Array.Copy(_items, index, _items, index + count, _size - index);
                }

                col.CopyTo(_items, index);
                _size += count;
                _version++;
            }
        }
        else
        {
            foreach (T item in collection)
            {
                Insert(index++, item);
            }
        }
    }
}
