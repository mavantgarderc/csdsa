using System;

namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides the <see cref="Dequeue"/> operation for
/// <see cref="PriorityQueueWrapper{TPriority, TValue}"/>.
/// </summary>
public partial class PriorityQueueWrapper<TPriority, TValue>
{
    /// <summary>
    /// Removes and returns the element with the highest priority (according to the underlying comparer).
/// </summary>
/// <returns>The element removed from the queue.</returns>
/// <exception cref="InvalidOperationException">Thrown when the priority queue is empty.</exception>
    public TValue Dequeue()
    {
        if (_priorityQueue.Count == 0)
        {
            throw new InvalidOperationException("Priority queue is empty.");
        }

        return _priorityQueue.Dequeue();
    }
}
