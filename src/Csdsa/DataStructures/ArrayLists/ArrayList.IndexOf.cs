using System;

namespace Csdsa.DataStructures.ArrayList;

/// <summary>
/// Provides the <see cref="IndexOf(T)"/> method for <see cref="ArrayList{T}"/>.
/// </summary>
public partial class ArrayList<T>
{
    /// <summary>
    /// Searches for the specified element and returns the zero-based index
    /// of the first occurrence within the list.
    /// </summary>
    /// <param name="item">The element to locate.</param>
    /// <returns>
    /// The zero-based index of the first occurrence of <paramref name="item"/>,
    /// if found; otherwise, -1.
    /// </returns>
    public int IndexOf(T item)
    {
        return Array.IndexOf(_items, item, 0, _size);
    }
}
