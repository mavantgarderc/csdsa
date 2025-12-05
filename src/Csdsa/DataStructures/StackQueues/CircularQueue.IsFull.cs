namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides the <see cref="IsFull"/> property for <see cref="CircularQueueUtils{T}"/>.
/// </summary>
public partial class CircularQueueUtils<T>
{
    /// <summary>
    /// Gets a value indicating whether the queue is full.
/// </summary>
    public bool IsFull => _size == _buffer.Length;
}
