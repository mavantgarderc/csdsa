using System;
using System.Collections.Generic;

namespace Csdsa.DataStructures.ArrayList;

/// <summary>
/// Provides the collection-based constructor for <see cref="ArrayList{T}"/>.
/// </summary>
public partial class ArrayList<T>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ArrayList{T}"/> class
    /// that contains elements copied from the specified collection.
    /// </summary>
    /// <param name="collection">The collection whose elements are copied to the new list.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="collection"/> is <see langword="null"/>.
    /// </exception>
    public ArrayList(IEnumerable<T> collection)
    {
        ArgumentNullException.ThrowIfNull(collection);

        if (collection is ICollection<T> col)
        {
            int count = col.Count;

            if (count == 0)
            {
                _items = [];
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
            _items = [];
            foreach (T item in collection)
            {
                Add(item);
            }
        }
    }
}
