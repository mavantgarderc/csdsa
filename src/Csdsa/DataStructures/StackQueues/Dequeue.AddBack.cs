namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides the <see cref="AddBack(T)"/> operation for <see cref="Dequeue{T}"/>.
/// </summary>
public partial class Dequeue<T>
{
    /// <summary>
    /// Adds an element to the back of the deque.
/// </summary>
/// <param name="item">The element to add.</param>
    public void AddBack(T item)
    {
        _list.AddLast(item);
    }
}
