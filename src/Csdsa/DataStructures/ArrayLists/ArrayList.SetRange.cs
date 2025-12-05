using System;
using System.Collections.Generic;

namespace Csdsa.DataStructures.ArrayList;

/// <summary>
/// Provides the <see cref="SetRange(int, ICollection{T})"/> method
/// for <see cref="ArrayList{T}"/>.
/// </summary>
public partial class ArrayList<T>
{
    /// <summary>
    /// Sets a contiguous range of elements in the list from the specified collection.
    /// </summary>
    /// <param name="startIndex">The zero-based starting index of the range to set.</param>
    /// <param name="collection">The collection providing the elements.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="collection"/> is <see langword="null"/>.
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="startIndex"/> is less than zero or greater than <see cref="Count"/>.
    /// </exception>
    public void SetRange(int startIndex, ICollection<T> collection)
    {
        ArgumentNullException.ThrowIfNull(collection);

        if (startIndex < 0 || startIndex > _size)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        int required = startIndex + collection.Count;
        EnsureCapacity(required);
        collection.CopyTo(_items, startIndex);

        if (required > _size)
        {
            _size = required;
        }

        _version++;
    }
}
