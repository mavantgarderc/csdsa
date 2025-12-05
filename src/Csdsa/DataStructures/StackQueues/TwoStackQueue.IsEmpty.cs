namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides the <see cref="IsEmpty"/> property for <see cref="TwoStackQueueUtils{T}"/>.
/// </summary>
public partial class TwoStackQueueUtils<T>
{
    /// <summary>
    /// Gets a value indicating whether the queue is empty.
/// </summary>
    public bool IsEmpty => _input.Count == 0 && _output.Count == 0;
}
