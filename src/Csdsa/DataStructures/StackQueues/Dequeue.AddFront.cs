namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides the <see cref="AddFront(T)"/> operation for <see cref="Dequeue{T}"/>.
/// </summary>
public partial class Dequeue<T>
{
    /// <summary>
    /// Adds an element to the front of the deque.
/// </summary>
/// <param name="item">The element to add.</param>
    public void AddFront(T item)
    {
        _list.AddFirst(item);
    }
}
