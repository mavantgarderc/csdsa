using System;

namespace Csdsa.DataStructures.ArrayList;

/// <summary>
/// Provides the capacity-based constructor for <see cref="ArrayList{T}"/>.
/// </summary>
public partial class ArrayList<T>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ArrayList{T}"/> class
    /// with the specified initial capacity.
    /// </summary>
    /// <param name="capacity">The initial number of elements that the list can contain.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="capacity"/> is less than zero.
    /// </exception>
    public ArrayList(int capacity)
    {
        if (capacity < 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(capacity),
                "Capacity cannot be negative.");
        }

        _items = capacity == 0 ? [] : new T[capacity];
    }
}
