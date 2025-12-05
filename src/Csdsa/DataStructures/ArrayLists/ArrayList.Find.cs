namespace Csdsa.DataStructures.ArrayList;

public partial class ArrayListUtils<T>
{
    /// <summary>
    /// Searches for an element that matches the conditions defined by the specified
    /// predicate, and returns the first occurrence.
    /// </summary>
    /// <param name="match">The predicate to test elements.</param>
    /// <returns>
    /// The first element that matches the predicate, if found; otherwise,
    /// <c>default(T)</c>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="match"/> is <see langword="null"/>.
    /// </exception>
    public T Find(Predicate<T> match)
    {
        ArgumentNullException.ThrowIfNull(match);

        if (_size == 0)
        {
            return default;
        }

        for (int i = 0; i < _size; i++)
        {
            if (match(_items[i]))
            {
                return _items[i];
            }
        }

        return default;
    }
}
