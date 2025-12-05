using System;

namespace Csdsa.DataStructures.ArrayList;

/// <summary>
/// Provides the <see cref="Clear"/> method for <see cref="ArrayList{T}"/>.
/// </summary>
public partial class ArrayList<T>
{
    /// <summary>
    /// Removes all elements from the list.
    /// </summary>
    public void Clear()
    {
        if (_size > 0)
        {
            Array.Clear(_items, 0, _size);
            _size = 0;
        }

        _version++;
    }
}
