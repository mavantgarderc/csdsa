using System.Collections;

namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides enumeration for <see cref="DoublyLinkedList{T}"/>.
/// </summary>
public partial class DoublyLinkedList<T>
{
    /// <inheritdoc />
    public IEnumerator<T> GetEnumerator()
    {
        return new DoublyLinkedListEnumerator<T>(_head, () => _version);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
