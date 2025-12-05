using System;

namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides the <see cref="PeekBack"/> operation for <see cref="Dequeue{T}"/>.
/// </summary>
public partial class Dequeue<T>
{
    /// <summary>
    /// Returns the element at the back of the deque without removing it.
/// </summary>
/// <returns>The element at the back of the deque.</returns>
/// <exception cref="InvalidOperationException">Thrown when the deque is empty.</exception>
    public T PeekBack()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("Dequeue is empty.");
        }

        return _list.Last.Value;
    }
}
