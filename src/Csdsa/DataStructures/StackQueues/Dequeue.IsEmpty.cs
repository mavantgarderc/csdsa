namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides the <see cref="IsEmpty"/> property for <see cref="Dequeue{T}"/>.
/// </summary>
public partial class Dequeue<T>
{
    /// <summary>
    /// Gets a value indicating whether the deque is empty.
/// </summary>
    public bool IsEmpty => _list.Count == 0;
}
