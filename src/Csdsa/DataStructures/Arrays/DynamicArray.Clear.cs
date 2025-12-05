using System;

namespace Csdsa.DataStructures.Arrays;

public partial class DynamicArray<T>
{
    /// <summary>
    /// Removes all elements from the dynamic array.
    /// </summary>
    public void Clear()
    {
        Array.Clear(_items, 0, _count);
        _count = 0;
    }
}
