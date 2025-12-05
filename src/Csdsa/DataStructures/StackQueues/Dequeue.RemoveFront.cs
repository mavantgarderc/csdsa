using System;

namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides the <see cref="RemoveFront"/> operation for <see cref="Dequeue{T}"/>.
/// </summary>
public partial class Dequeue<T>
{
    /// <summary>
    /// Removes and returns the element at the front of the deque.
/// </summary>
/// <returns>The element removed from the front of the deque.</returns>
/// <exception cref="InvalidOperationException">Thrown when the deque is empty.</exception>
    public T RemoveFront()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("Dequeue is empty.");
        }

        T item = _list.First.Value;
        _list.RemoveFirst();
        return item;
    }
}
