using System;

namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides the <see cref="Peek"/> operation for
/// <see cref="PriorityQueueWrapper{TPriority, TValue}"/>.
/// </summary>
public partial class PriorityQueueWrapper<TPriority, TValue>
{
    /// <summary>
    /// Returns the element with the highest priority without removing it.
/// </summary>
/// <returns>The element at the front of the queue.</returns>
/// <exception cref="InvalidOperationException">Thrown when the priority queue is empty.</exception>
    public TValue Peek()
    {
        if (_priorityQueue.Count == 0)
        {
            throw new InvalidOperationException("Priority queue is empty.");
        }

        return _priorityQueue.Peek();
    }
}
