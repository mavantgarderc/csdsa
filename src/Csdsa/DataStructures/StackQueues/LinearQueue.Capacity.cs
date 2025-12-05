namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides the <see cref="Capacity"/> property for <see cref="LinearQueueUtils{T}"/>.
/// </summary>
public partial class LinearQueueUtils<T>
{
    /// <summary>
    /// Gets the maximum number of elements that the queue can contain.
/// </summary>
    public int Capacity => _items.Length;
}
