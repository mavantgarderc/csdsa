using System;
using System.Collections.Generic;

namespace Csdsa.DataStructures.Lists;

/// <summary>
/// Provides the <see cref="SortDescending{T}(System.Collections.Generic.List{T})"/> method
/// for sorting lists in descending order.
/// </summary>
public static partial class ListT
{
    /// <summary>
    /// Sorts the elements in the specified list in descending order
    /// using the default comparer.
    /// </summary>
    /// <typeparam name="T">
    /// The element type of the list, which must implement <see cref="IComparable{T}"/>.
    /// </typeparam>
    /// <param name="list">The list to sort.</param>
    /// <exception cref="ArgumentException">
    /// Thrown when <paramref name="list"/> is <see langword="null"/>.
    /// </exception>
    public static void SortDescending<T>(List<T> list)
        where T : IComparable<T>
    {
        if (list == null)
        {
            throw new ArgumentException("List cannot be null.");
        }

        list.Sort((a, b) => b.CompareTo(a));
    }
}
