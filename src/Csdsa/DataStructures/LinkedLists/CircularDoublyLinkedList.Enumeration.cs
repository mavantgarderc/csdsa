using System;
using System.Collections;
using System.Collections.Generic;

namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides enumeration for <see cref="CircularDoublyLinkedList{T}"/>.
/// </summary>
public partial class CircularDoublyLinkedList<T>
{
    /// <inheritdoc />
    public IEnumerator<T> GetEnumerator()
    {
        if (_head == null)
        {
            yield break;
        }

        LinkedListNode<T> start = _head;
        LinkedListNode<T> current = start;
        int version = _version;

        do
        {
            if (version != _version)
            {
                throw new InvalidOperationException("Collection modified");
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
