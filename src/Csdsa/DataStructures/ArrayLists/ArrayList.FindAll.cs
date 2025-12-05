namespace Csdsa.DataStructures.ArrayList;

public partial class ArrayListUtils<T>
{
    /// <summary>
    /// Retrieves all elements that match the conditions defined by the specified predicate.
    /// </summary>
    /// <param name="match">The predicate to test elements.</param>
    /// <returns>
    /// A new <see cref="ArrayListUtils{T}"/> containing all matching elements.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="match"/> is <see langword="null"/>.
    /// </exception>
    public ArrayListUtils<T> FindAll(Predicate<T> match)
    {
        ArgumentNullException.ThrowIfNull(match);

        ArrayListUtils<T> result = new ArrayListUtils<T>();

        for (int i = 0; i < _size; i++)
        {
            if (match(_items[i]))
            {
                result.Add(_items[i]);
            }
        }

        return result;
    }
}
