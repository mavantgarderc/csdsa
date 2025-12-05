using System;

namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides the <see cref="Peek"/> operation for <see cref="TwoStackQueueUtils{T}"/>.
/// </summary>
public partial class TwoStackQueueUtils<T>
{
    /// <summary>
    /// Returns the element at the front of the queue without removing it.
/// </summary>
/// <returns>The element at the front of the queue.</returns>
/// <exception cref="InvalidOperationException">Thrown when the queue is empty.</exception>
    public T Peek()
    {
        Transfer();

        if (_output.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        return _output.Peek();
    }
}
