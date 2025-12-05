using System;
using System.Collections.Generic;

namespace Csdsa.DataStructures.Lists;

/// <summary>
/// Provides the <see cref="Clone{T}(System.Collections.Generic.List{T})"/> method
/// for cloning lists.
/// </summary>
public static partial class ListT
{
    /// <summary>
    /// Creates a new list that contains the same elements as the specified list.
    /// </summary>
    /// <typeparam name="T">The element type of the list.</typeparam>
    /// <param name="list">The list to clone.</param>
    /// <returns>
    /// A new <see cref="List{T}"/> containing the elements of <paramref name="list"/>.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// Thrown when <paramref name="list"/> is <see langword="null"/>.
    /// </exception>
    public static List<T> Clone<T>(List<T> list)
    {
        if (list == null)
        {
            throw new ArgumentException("List cannot be null.");
        }

        return new List<T>(list);
    }
}
