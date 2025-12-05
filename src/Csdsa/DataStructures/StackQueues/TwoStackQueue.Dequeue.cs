using System;

namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides the <see cref="Dequeue"/> operation for <see cref="TwoStackQueueUtils{T}"/>.
/// </summary>
public partial class TwoStackQueueUtils<T>
{
    /// <summary>
    /// Removes and returns the element at the front of the queue.
/// </summary>
/// <returns>The element removed from the front of the queue.</returns>
/// <exception cref="InvalidOperationException">Thrown when the queue is empty.</exception>
    public T Dequeue()
    {
        Transfer();

        if (_output.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        return _output.Pop();
    }
}
