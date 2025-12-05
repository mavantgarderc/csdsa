using System;
using System.Collections.Generic;

namespace Csdsa.DataStructures.Lists;

/// <summary>
/// Provides the <see cref="Add{T}(System.Collections.Generic.List{T}, T)"/> method
/// for adding elements to a list.
/// </summary>
public static partial class ListT
{
    /// <summary>
    /// Adds an element to the end of the specified list.
    /// </summary>
    /// <typeparam name="T">The element type of the list.</typeparam>
    /// <param name="list">The list to which the element will be added.</param>
    /// <param name="item">The element to add.</param>
    /// <exception cref="ArgumentException">
    /// Thrown when <paramref name="list"/> is <see langword="null"/>.
    /// </exception>
    public static void Add<T>(List<T> list, T item)
    {
        if (list == null)
        {
            throw new ArgumentException("List cannot be null.");
        }

        list.Add(item);
    }
}
