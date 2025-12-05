namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides the <see cref="IsEmpty"/> property for <see cref="LinearQueueUtils{T}"/>.
/// </summary>
public partial class LinearQueueUtils<T>
{
    /// <summary>
    /// Gets a value indicating whether the queue is empty.
/// </summary>
    public bool IsEmpty => _count == 0;
}
