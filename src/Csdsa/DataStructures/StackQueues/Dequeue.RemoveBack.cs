using System;

namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides the <see cref="RemoveBack"/> operation for <see cref="Dequeue{T}"/>.
/// </summary>
public partial class Dequeue<T>
{
    /// <summary>
    /// Removes and returns the element at the back of the deque.
/// </summary>
/// <returns>The element removed from the back of the deque.</returns>
/// <exception cref="InvalidOperationException">Thrown when the deque is empty.</exception>
    public T RemoveBack()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("Dequeue is empty.");
        }

        T item = _list.Last.Value;
        _list.RemoveLast();
        return item;
    }
}
