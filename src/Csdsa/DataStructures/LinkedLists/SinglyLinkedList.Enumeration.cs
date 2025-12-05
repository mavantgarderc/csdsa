using System.Collections;

namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides enumeration for <see cref="SinglyLinkedList{T}"/>.
/// </summary>
public partial class SinglyLinkedList<T>
{
    /// <inheritdoc />
    public IEnumerator<T> GetEnumerator()
    {
        return new SinglyLinkedListEnumerator<T>(_head, () => _version);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
