using System.Collections;

namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides enumeration for <see cref="CircularLinkedList{T}"/>.
/// </summary>
public partial class CircularLinkedList<T>
{
    /// <inheritdoc />
    public IEnumerator<T> GetEnumerator()
    {
        if (_tail == null)
        {
            yield break;
        }

        SinglyLinkedListNode<T> start = Head;
        SinglyLinkedListNode<T> current = start;
        int version = _version;

        do
        {
            if (version != _version)
            {
                throw new InvalidOperationException("collection modified");
            }

            yield return current.Value;
            current = current.Next;
        }
        while (!ReferenceEquals(current, start));
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
