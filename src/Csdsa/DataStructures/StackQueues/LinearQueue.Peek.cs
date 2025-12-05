using System;

namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides the <see cref="Peek"/> operation for <see cref="LinearQueueUtils{T}"/>.
/// </summary>
public partial class LinearQueueUtils<T>
{
    /// <summary>
    /// Returns the element at the front of the queue without removing it.
    /// </summary>
    /// <returns>The element at the front of the queue.</returns>
    /// <exception cref="InvalidOperationException">Thrown when the queue is empty.</exception>
    public T Peek()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        return _items[_front];
    }
}
