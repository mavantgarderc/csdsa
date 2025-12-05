using System;
using System.Collections.Generic;

namespace Csdsa.DataStructures.Lists;

/// <summary>
/// Provides the <see cref="Merge{T}(System.Collections.Generic.List{T}, System.Collections.Generic.List{T})"/> method
/// for combining lists.
/// </summary>
public static partial class ListT
{
    /// <summary>
    /// Merges two lists into a new list that contains all the elements of both inputs.
    /// </summary>
    /// <typeparam name="T">The element type of the lists.</typeparam>
    /// <param name="a">The first list.</param>
    /// <param name="b">The second list.</param>
    /// <returns>
    /// A new <see cref="List{T}"/> containing the elements of <paramref name="a"/> followed by
    /// the elements of <paramref name="b"/>.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// Thrown when <paramref name="a"/> or <paramref name="b"/> is <see langword="null"/>.
    /// </exception>
    public static List<T> Merge<T>(List<T> a, List<T> b)
    {
        if (a == null || b == null)
        {
            throw new ArgumentException("Input lists cannot be null.");
        }

        List<T> result = new List<T>(a.Count + b.Count);
        result.AddRange(a);
        result.AddRange(b);
        return result;
    }
}
