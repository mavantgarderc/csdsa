using System;
using System.Collections.Generic;

namespace Csdsa.Algorithms.Search.Linear;

public static partial class LinearSearch
{
    /// <summary>
    /// Returns the first element in the sequence that satisfies the specified predicate,
    /// or the default value of <typeparamref name="T"/> if no such element is found.
    /// </summary>
    /// <typeparam name="T">The element type of the sequence.</typeparam>
    /// <param name="collection">The sequence to search.</param>
    /// <param name="match">The predicate used to test each element.</param>
    /// <returns>
    /// The first matching element, or <c>default(T)</c> if no match is found.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="collection"/> or <paramref name="match"/> is <see langword="null"/>.
    /// </exception>
    public static T FirstOrDefaultMatch<T>(this IEnumerable<T> collection, Func<T, bool> match)
    {
        ArgumentNullException.ThrowIfNull(collection);
        ArgumentNullException.ThrowIfNull(match);

        foreach (T item in collection)
        {
            if (match(item))
            {
                return item;
            }
        }

        return default;
    }
}
