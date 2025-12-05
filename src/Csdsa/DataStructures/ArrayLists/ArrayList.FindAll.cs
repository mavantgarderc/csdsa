using System;
using System.Collections.Generic;

namespace Csdsa.DataStructures.ArrayList;

/// <summary>
/// Provides the <see cref="FindAll(System.Predicate{T})"/> method
/// for <see cref="ArrayList{T}"/>.
/// </summary>
public partial class ArrayList<T>
{
    /// <summary>
    /// Retrieves all elements that match the conditions defined by the specified predicate.
    /// </summary>
    /// <param name="match">The predicate to test elements.</param>
    /// <returns>
    /// A new <see cref="ArrayList{T}"/> containing all matching elements.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="match"/> is <see langword="null"/>.
    /// </exception>
    public ArrayList<T> FindAll(Predicate<T> match)
    {
        ArgumentNullException.ThrowIfNull(match);

        ArrayList<T> result = new ArrayList<T>();

        for (int i = 0; i < _size; i++)
        {
            if (match(_items[i]))
            {
                result.Add(_items[i]);
            }
        }

        return result;
    }
}
