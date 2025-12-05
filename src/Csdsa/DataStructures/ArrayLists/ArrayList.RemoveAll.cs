namespace Csdsa.DataStructures.ArrayList;

public partial class ArrayListUtils<T>
{
    /// <summary>
    /// Removes all the elements that match the conditions defined by the specified predicate.
    /// </summary>
    /// <param name="match">The predicate to test elements to be removed.</param>
    /// <returns>
    /// The number of elements removed from the list.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="match"/> is <see langword="null"/>.
    /// </exception>
    public int RemoveAll(Predicate<T> match)
    {
        ArgumentNullException.ThrowIfNull(match);

        int freeIndex = 0;

        while (freeIndex < _size && !match(_items[freeIndex]))
        {
            freeIndex++;
        }

        if (freeIndex >= _size)
        {
            return 0;
        }

        int current = freeIndex + 1;

        while (current < _size)
        {
            while (current < _size && match(_items[current]))
            {
                current++;
            }

            if (current < _size)
            {
                _items[freeIndex++] = _items[current++];
            }
        }

        Array.Clear(_items, freeIndex, _size - freeIndex);
        int removed = _size - freeIndex;
        _size = freeIndex;
        _version++;

        return removed;
    }
}
