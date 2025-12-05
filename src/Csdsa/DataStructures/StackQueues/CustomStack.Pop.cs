using System;

namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides the <see cref="Pop"/> operation for <see cref="CustomStackUtils{T}"/>.
/// </summary>
public partial class CustomStackUtils<T>
{
    /// <summary>
    /// Removes and returns the element at the top of the stack.
    /// </summary>
    /// <returns>The element removed from the top of the stack.</returns>
    /// <exception cref="InvalidOperationException">Thrown when the stack is empty.</exception>
    public T Pop()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        T item = _list[^1];
        _list.RemoveAt(_list.Count - 1);
        return item;
    }
}
