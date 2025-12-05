using System;
using System.Collections.Generic;

namespace Csdsa.DataStructures.Lists;

/// <summary>
/// Provides the <see cref="SortAscending{T}(System.Collections.Generic.List{T})"/> method
/// for sorting lists in ascending order.
/// </summary>
public static partial class ListT
{
    /// <summary>
    /// Sorts the elements in the specified list in ascending order using the default comparer.
    /// </summary>
    /// <typeparam name="T">
    /// The element type of the list, which must implement <see cref="IComparable{T}"/>.
    /// </typeparam>
    /// <param name="list">The list to sort.</param>
    /// <exception cref="ArgumentException">
    /// Thrown when <paramref name="list"/> is <see langword="null"/>.
    /// </exception>
    public static void SortAscending<T>(List<T> list)
        where T : IComparable<T>
    {
        if (list == null)
        {
            throw new ArgumentException("List cannot be null.");
        }

        list.Sort();
    }
}
