using System;
using System.Collections.Generic;

namespace Csdsa.DataStructures.Lists;

/// <summary>
/// Provides the <see cref="Reverse{T}(System.Collections.Generic.List{T})"/> method
/// for reversing lists.
/// </summary>
public static partial class ListT
{
    /// <summary>
    /// Reverses the order of the elements in the specified list.
    /// </summary>
    /// <typeparam name="T">The element type of the list.</typeparam>
    /// <param name="list">The list whose elements to reverse.</param>
    /// <exception cref="ArgumentException">
    /// Thrown when <paramref name="list"/> is <see langword="null"/>.
    /// </exception>
    public static void Reverse<T>(List<T> list)
    {
        if (list == null)
        {
            throw new ArgumentException("List cannot be null.");
        }

        list.Reverse();
    }
}
