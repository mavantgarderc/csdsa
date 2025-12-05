using System;

namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides the <see cref="Dequeue"/> operation for <see cref="CustomQueueUtils{T}"/>.
/// </summary>
public partial class CustomQueueUtils<T>
{
    /// <summary>
    /// Removes and returns the element at the front of the queue.
    /// </summary>
    /// <returns>The element removed from the front of the queue.</returns>
    /// <exception cref="InvalidOperationException">Thrown when the queue is empty.</exception>
    public T Dequeue()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        T item = _list[0];
        _list.RemoveAt(0);
        return item;
    }
}
