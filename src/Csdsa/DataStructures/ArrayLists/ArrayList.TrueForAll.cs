using System;
using System.Collections.Generic;

namespace Csdsa.DataStructures.ArrayList;

/// <summary>
/// Provides the <see cref="TrueForAll(System.Predicate{T})"/> method
/// for <see cref="ArrayList{T}"/>.
/// </summary>
public partial class ArrayList<T>
{
    /// <summary>
    /// Determines whether every element in the list matches the conditions
    /// defined by the specified predicate.
    /// </summary>
    /// <param name="match">The predicate to test elements.</param>
    /// <returns>
    /// <see langword="true"/> if every element matches the predicate
    /// or the list is empty; otherwise, <see langword="false"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="match"/> is <see langword="null"/>.
    /// </exception>
    public bool TrueForAll(Predicate<T> match)
    {
        ArgumentNullException.ThrowIfNull(match);

        if (_size == 0)
        {
            return true;
        }

        for (int i = 0; i < _size; i++)
        {
            if (!match(_items[i]))
            {
                return false;
            }
        }

        return true;
    }
}
