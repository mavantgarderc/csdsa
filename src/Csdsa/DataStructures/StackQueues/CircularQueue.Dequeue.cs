namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides the <see cref="Dequeue"/> operation for <see cref="CircularQueueUtils{T}"/>.
/// </summary>
public partial class CircularQueueUtils<T>
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

        T item = _buffer[_head];
        _head = (_head + 1) % _buffer.Length;
        _size--;
        return item;
    }
}
