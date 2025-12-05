using System;
using System.Collections.Generic;

namespace Csdsa.DataStructures.ArrayList;

/// <summary>
/// Provides the <see cref="Exists(System.Predicate{T})"/> method
/// for <see cref="ArrayList{T}"/>.
/// </summary>
public partial class ArrayList<T>
{
    /// <summary>
    /// Determines whether the list contains an element that matches
    /// the conditions defined by the specified predicate.
    /// </summary>
    /// <param name="match">The predicate to test elements.</param>
    /// <returns>
    /// <see langword="true"/> if an element that matches the predicate is found;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    public bool Exists(Predicate<T> match)
    {
        return FindIndex(match) != -1;
    }
}
