using System.Collections.Generic;

namespace Csdsa.DataStructures.ArrayList;

public partial class ArrayList<T>
{
    /// <summary>
    /// Adds the elements of the specified collection to the end of the list.
    /// </summary>
    /// <param name="collection">The collection whose elements should be added.</param>
    public void AddRange(IEnumerable<T> collection)
    {
        InsertRange(_size, collection);
    }
}
