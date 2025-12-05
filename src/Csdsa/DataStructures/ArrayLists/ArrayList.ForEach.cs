namespace Csdsa.DataStructures.ArrayList;

public partial class ArrayListUtils<T>
{
    /// <summary>
    /// Performs the specified action on each element of the list.
    /// </summary>
    /// <param name="action">The action to perform on each element.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="action"/> is <see langword="null"/>.
    /// </exception>
    /// <exception cref="InvalidOperationException">
    /// Thrown when the list is modified during iteration.
    /// </exception>
    public void ForEach(Action<T> action)
    {
        ArgumentNullException.ThrowIfNull(action);

        if (_size == 0)
        {
            return;
        }

        int version = _version;

        for (int i = 0; i < _size; i++)
        {
            if (version != _version)
            {
                throw new InvalidOperationException("Collection was modified during enumeration.");
            }

            action(_items[i]);
        }
    }
}
