namespace Csdsa.DataStructures.ArrayList;

public partial class ArrayListUtils<T>
{
    /// <summary>
    /// Initializes a new instance of the "ArrayListUtils{T}" class
    /// that contains elements copied from the specified collection.
    /// </summary>
    /// <param name="collection">The collection whose elements are copied to the new list.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="collection"/> is <see langword="null"/>.
    /// </exception>
    public ArrayListUtils(IEnumerable<T> collection)
    {
        ArgumentNullException.ThrowIfNull(collection);

        if (collection is ICollection<T> col)
        {
            int count = col.Count;

            if (count == 0)
            {
                _items = default;
                _size = 0;
            }
            else
            {
                _items = new T[count];
                col.CopyTo(_items, 0);
                _size = count;
            }
        }
        else
        {
            _items = default;
            _size = 0;

            foreach (T item in collection)
            {
                Add(item);
            }
        }

        _version++;
    }
}
