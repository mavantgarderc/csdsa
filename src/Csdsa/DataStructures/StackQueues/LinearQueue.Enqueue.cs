using System;

namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides the <see cref="Enqueue(T)"/> operation for <see cref="LinearQueueUtils{T}"/>.
/// </summary>
public partial class LinearQueueUtils<T>
{
    /// <summary>
    /// Adds an element to the end of the queue.
    /// </summary>
    /// <param name="item">The element to enqueue.</param>
    /// <exception cref="InvalidOperationException">Thrown when the queue is full.</exception>
    public void Enqueue(T item)
    {
        if (_rear == _items.Length)
        {
            throw new InvalidOperationException("Queue is full.");
        }

        _items[_rear] = item;
        _rear++;
        _count++;
    }
}
