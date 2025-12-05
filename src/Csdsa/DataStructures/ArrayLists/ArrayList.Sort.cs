namespace Csdsa.DataStructures.ArrayList;

public partial class ArrayListUtils<T>
{
    /// <summary>
    /// Sorts the elements in the entire list using the default comparer.
    /// </summary>
    public void Sort()
    {
        Sort(Comparer<T>.Default);
    }

    /// <summary>
    /// Sorts the elements in the entire list using the specified comparer.
    /// </summary>
    /// <param name="comparer">
    /// The comparer to use, or <see langword="null"/> to use <see cref="Comparer{T}.Default"/>.
    /// </param>
    public void Sort(IComparer<T> comparer)
    {
        comparer ??= Comparer<T>.Default;
        Array.Sort(_items, 0, _size, comparer);
        _version++;
    }

    /// <summary>
    /// Sorts the elements in a range of the list using the specified comparer.
    /// </summary>
    /// <param name="index">The zero-based starting index of the range to sort.</param>
    /// <param name="count">The number of elements in the range to sort.</param>
    /// <param name="comparer">
    /// The comparer to use, or <see langword="null"/> to use <see cref="Comparer{T}.Default"/>.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="index"/> or <paramref name="count"/> is less than zero.
    /// </exception>
    /// <exception cref="ArgumentException">
    /// Thrown when the range defined by <paramref name="index"/> and <paramref name="count"/>
    /// exceeds the bounds of the list.
    /// </exception>
    public void Sort(int index, int count, IComparer<T> comparer)
    {
        if (index < 0 || count < 0)
        {
            throw new ArgumentOutOfRangeException(index < 0 ? nameof(index) : nameof(count));
        }

        if (_size - index < count)
        {
            throw new ArgumentException("Invalid offset and length.");
        }

        comparer ??= Comparer<T>.Default;
        Array.Sort(_items, index, count, comparer);
        _version++;
    }
}
