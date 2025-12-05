namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides the <see cref="IsEmpty"/> property for <see cref="CircularQueueUtils{T}"/>.
/// </summary>
public partial class CircularQueueUtils<T>
{
    /// <summary>
    /// Gets a value indicating whether the queue is empty.
/// </summary>
    public bool IsEmpty => _size == 0;
}
