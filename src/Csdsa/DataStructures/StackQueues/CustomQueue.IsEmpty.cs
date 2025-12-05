namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides the <see cref="IsEmpty"/> property for <see cref="CustomQueueUtils{T}"/>.
/// </summary>
public partial class CustomQueueUtils<T>
{
    /// <summary>
    /// Gets a value indicating whether the queue is empty.
    /// </summary>
    public bool IsEmpty => _list.Count == 0;
}
