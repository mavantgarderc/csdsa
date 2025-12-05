namespace Csdsa.DataStructures.Arrays;

public partial class DynamicArray<T>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DynamicArray{T}"/> class
    /// with the specified initial capacity.
    /// </summary>
    /// <param name="capacity">
    /// The initial number of elements that the dynamic array can contain.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="capacity"/> is less than or equal to zero.
    /// </exception>
    public DynamicArray(int capacity = 4)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(capacity);

        _items = new T[capacity];
        _count = 0;
    }
}
