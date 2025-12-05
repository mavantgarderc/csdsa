namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides the <see cref="Enqueue(T)"/> operation for <see cref="CustomQueueUtils{T}"/>.
/// </summary>
public partial class CustomQueueUtils<T>
{
    /// <summary>
    /// Adds an element to the end of the queue.
    /// </summary>
    /// <param name="item">The element to enqueue.</param>
    public void Enqueue(T item)
    {
        _list.Add(item);
    }
}
