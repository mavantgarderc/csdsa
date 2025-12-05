namespace Csdsa.DataStructures.ArrayList;

/// <summary>
/// Provides the <see cref="GetRange(int, int)"/> method for <see cref="ArrayListUtils{T}"/>.
/// </summary>
public partial class ArrayListUtils<T>
{
    /// <summary>
    /// Creates a shallow copy of a range of elements in the list.
    /// </summary>
    /// <param name="startIndex">The zero-based starting index of the range.</param>
    /// <param name="count">The number of elements in the range.</param>
    /// <returns>
    /// A new <see cref="ArrayListUtils{T}"/> containing the specified range of elements.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="startIndex"/> or <paramref name="count"/> is negative.
    /// </exception>
    /// <exception cref="ArgumentException">
    /// Thrown when <paramref name="startIndex"/> and <paramref name="count"/> do not specify a valid range.
    /// </exception>
    public ArrayListUtils<T> GetRange(int startIndex, int count)
    {
        if (startIndex < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex), "Start index must be non-negative.");
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count), "Count must be non-negative.");
        }

        if (_size - startIndex < count)
        {
            throw new ArgumentException("The range defined by startIndex and count exceeds the bounds of the list.");
        }

        ArrayListUtils<T> result = new ArrayListUtils<T>(count);

        if (count > 0)
        {
            Array.Copy(_items, startIndex, result._items, 0, count);
            result._size = count;
        }

        return result;
    }
}
