namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides the <see cref="Count"/> property for <see cref="LinearQueueUtils{T}"/>.
/// </summary>
public partial class LinearQueueUtils<T>
{
    /// <summary>
    /// Gets the number of elements currently stored in the queue.
    /// </summary>
    public int Count => _count;
}
