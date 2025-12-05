using System;

namespace Csdsa.DataStructures.ArrayList;

/// <summary>
/// Provides capacity management for <see cref="ArrayList{T}"/>.
/// </summary>
public partial class ArrayList<T>
{
    /// <summary>
    /// Ensures that the list can hold at least the specified number of elements
    /// without resizing.
    /// </summary>
    /// <param name="minCapacity">The minimum required capacity.</param>
    public void EnsureCapacity(int minCapacity)
    {
        if (minCapacity > Capacity)
        {
            int newCapacity = _items.Length == 0 ? DefaultCapacity : _items.Length * 2;

            if ((uint)newCapacity > MaxArrayLength)
            {
                newCapacity = MaxArrayLength;
            }

            if (newCapacity < minCapacity)
            {
                newCapacity = minCapacity;
            }

            Capacity = newCapacity;
        }
    }
}
