using System;

namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides the <see cref="Peek"/> operation for <see cref="CustomStackUtils{T}"/>.
/// </summary>
public partial class CustomStackUtils<T>
{
    /// <summary>
    /// Returns the element at the top of the stack without removing it.
    /// </summary>
    /// <returns>The element at the top of the stack.</returns>
    /// <exception cref="InvalidOperationException">Thrown when the stack is empty.</exception>
    public T Peek()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        return _list[^1];
    }
}
