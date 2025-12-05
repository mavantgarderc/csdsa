namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides <see cref="ILinkedList{T}.ReverseIterator"/> implementation
/// for <see cref="SinglyLinkedList{T}"/>.
/// </summary>
public partial class SinglyLinkedList<T>
{
    /// <inheritdoc />
    public IEnumerable<T> ReverseIterator()
    {
        Stack<T> stack = new Stack<T>();
        SinglyLinkedListNode<T> current = _head;

        while (current != null)
        {
            stack.Push(current.Value);
            current = current.Next;
        }

        while (stack.Count > 0)
        {
            yield return stack.Pop();
        }
    }
}
