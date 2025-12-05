namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides the <see cref="Enqueue(T)"/> operation for <see cref="CircularQueueUtils{T}"/>.
/// </summary>
public partial class CircularQueueUtils<T>
{
    /// <summary>
    /// Adds an element to the end of the queue.
    /// </summary>
    /// <param name="item">The element to enqueue.</param>
    /// <exception cref="InvalidOperationException">Thrown when the queue is full.</exception>
    public void Enqueue(T item)
    {
        if (_size == _buffer.Length)
        {
            throw new InvalidOperationException("Queue is full.");
        }

        _buffer[_tail] = item;
        _tail = (_tail + 1) % _buffer.Length;
        _size++;
    }
}
