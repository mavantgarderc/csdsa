namespace Csdsa.DataStructures.ArrayList;

/// <summary>
/// Provides the <see cref="Capacity"/> property for <see cref="ArrayListUtils{T}"/>.
/// </summary>
public partial class ArrayListUtils<T>
{
    /// <summary>
    /// Gets or sets the total number of elements that the internal array can hold
    /// without resizing.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when the specified capacity is less than the current Count.
    /// </exception>
    public int Capacity
    {
        get
        {
            return _items.Length;
        }

        set
        {
            if (value < _size)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(value),
                    "Capacity cannot be less than the current element count.");
            }

            if (value != _items.Length)
            {
                if (value > 0)
                {
                    T[] newItems = new T[value];

                    if (_size > 0)
                    {
                        Array.Copy(_items, 0, newItems, 0, _size);
                    }

                    _items = newItems;
                }
                else
                {
                    _items = Array.Empty<T>();
                }
            }
        }
    }
}
