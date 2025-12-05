namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides the <see cref="IsEmpty"/> property for
/// <see cref="PriorityQueueWrapper{TPriority, TValue}"/>.
/// </summary>
public partial class PriorityQueueWrapper<TPriority, TValue>
{
    /// <summary>
    /// Gets a value indicating whether the priority queue is empty.
/// </summary>
    public bool IsEmpty => _priorityQueue.Count == 0;
}
