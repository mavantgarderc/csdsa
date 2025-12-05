namespace Csdsa.DataStructures.ArrayList;

/// <summary>
/// Provides the capacity-based constructor for <see cref="ArrayListUtils{T}"/>.
/// </summary>
public partial class ArrayListUtils<T>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ArrayListUtils{T}"/> class
    /// with the specified initial capacity.
    /// </summary>
    /// <param name="capacity">The initial number of elements that the list can contain.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="capacity"/> is less than zero.
    /// </exception>
    public ArrayListUtils(int capacity)
    {
        if (capacity < 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(capacity),
                "Capacity cannot be negative.");
        }

        if (capacity == 0)
        {
            _items = Array.Empty<T>();
        }
        else
        {
            _items = new T[capacity];
        }

        _size = 0;
        _version = 0;
    }
}
