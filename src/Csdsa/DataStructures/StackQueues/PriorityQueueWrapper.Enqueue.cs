namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides the <see cref="Enqueue(TValue, TPriority)"/> operation for
/// <see cref="PriorityQueueWrapper{TPriority, TValue}"/>.
/// </summary>
public partial class PriorityQueueWrapper<TPriority, TValue>
{
    /// <summary>
    /// Adds an element with the specified priority to the queue.
    /// </summary>
    /// <param name="value">The value to enqueue.</param>
    /// <param name="priority">The priority associated with the value.</param>
    public void Enqueue(TValue value, TPriority priority)
    {
        _priorityQueue.Enqueue(value, priority);
    }
}
