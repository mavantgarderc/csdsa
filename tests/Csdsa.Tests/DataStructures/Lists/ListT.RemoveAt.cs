using System;
using System.Collections.Generic;

namespace Csdsa.DataStructures.Lists;

/// <summary>
/// Provides the <see cref="RemoveAt{T}(System.Collections.Generic.List{T}, int)"/> method
/// for removing elements from a list at a specific index.
/// </summary>
public static partial class ListT
{
    /// <summary>
    /// Removes the element at the specified index from the list.
    /// </summary>
    /// <typeparam name="T">The element type of the list.</typeparam>
    /// <param name="list">The list from which the element will be removed.</param>
    /// <param name="index">The zero-based index of the element to remove.</param>
    /// <exception cref="ArgumentException">
    /// Thrown when <paramref name="list"/> is <see langword="null"/> or
    /// when <paramref name="index"/> is less than zero or greater than or equal to <c>list.Count</c>.
    /// </exception>
    public static void RemoveAt<T>(List<T> list, int index)
    {
        if (list == null)
        {
            throw new ArgumentException("List cannot be null.");
        }

        if (index < 0 || index >= list.Count)
        {
            throw new ArgumentException(null, nameof(index));
        }

        list.RemoveAt(index);
    }
}
