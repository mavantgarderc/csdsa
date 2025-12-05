using System.Collections.Generic;

namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="ILinkedList{T}.GetNodeDepth"/> implementation
/// for <see cref="SinglyLinkedList{T}"/>.
/// </summary>
public partial class SinglyLinkedList<T>
{
    /// <inheritdoc />
    public int GetNodeDepth(T item)
    {
        int depth = 0;
        SinglyLinkedListNode<T> current = _head;
        EqualityComparer<T> comparer = EqualityComparer<T>.Default;

        while (current != null)
        {
            if (comparer.Equals(current.Value, item))
            {
                return depth;
            }

            depth++;
            current = current.Next;
        }

        return -1;
    }
}
