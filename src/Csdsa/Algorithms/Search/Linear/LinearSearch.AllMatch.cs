using System;
using System.Collections.Generic;

namespace Csdsa.Algorithms.Search.Linear;

public static partial class LinearSearch
{
    /// <summary>
    /// Determines whether all elements in the sequence satisfy the specified predicate.
    /// </summary>
    /// <typeparam name="T">The element type of the sequence.</typeparam>
    /// <param name="collection">The sequence to test.</param>
    /// <param name="match">The predicate used to test each element.</param>
    /// <returns>
    /// <see langword="true"/> if all elements satisfy <paramref name="match"/>;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="collection"/> or <paramref name="match"/> is <see langword="null"/>.
    /// </exception>
    public static bool AllMatch<T>(this IEnumerable<T> collection, Func<T, bool> match)
    {
        ArgumentNullException.ThrowIfNull(collection);
        ArgumentNullException.ThrowIfNull(match);

        foreach (T item in collection)
        {
            if (!match(item))
            {
                return false;
            }
        }

        return true;
    }
}
