using System;
using System.Collections.Generic;

namespace Csdsa.DataStructures.Lists;

/// <summary>
/// Provides the <see cref="InsertAt{T}(System.Collections.Generic.List{T}, int, T)"/> method
/// for inserting elements into a list at a specific index.
/// </summary>
public static partial class ListT
{
    /// <summary>
    /// Inserts an element into the specified list at the given index.
    /// </summary>
    /// <typeparam name="T">The element type of the list.</typeparam>
    /// <param name="list">The list into which the element will be inserted.</param>
    /// <param name="index">The zero-based index at which to insert the element.</param>
    /// <param name="item">The element to insert.</param>
    /// <exception cref="ArgumentException">
    /// Thrown when <paramref name="list"/> is <see langword="null"/> or
    /// when <paramref name="index"/> is less than zero or greater than <c>list.Count</c>.
    /// </exception>
    public static void InsertAt<T>(List<T> list, int index, T item)
    {
        if (list == null)
        {
            throw new ArgumentException("List cannot be null.");
        }

        if (index < 0 || index > list.Count)
        {
            throw new ArgumentException(null, nameof(index));
        }

        list.Insert(index, item);
    }
}
