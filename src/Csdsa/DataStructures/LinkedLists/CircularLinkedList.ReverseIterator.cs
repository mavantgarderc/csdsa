namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides <see cref="ILinkedList{T}.ReverseIterator"/> implementation
/// for <see cref="CircularLinkedList{T}"/>.
/// </summary>
public partial class CircularLinkedList<T>
{
    /// <inheritdoc />
    public IEnumerable<T> ReverseIterator()
    {
        if (_tail == null)
        {
            yield break;
        }

        Stack<T> stack = new Stack<T>();
        SinglyLinkedListNode<T> current = Head;
        SinglyLinkedListNode<T> start = current;

        do
        {
            stack.Push(current.Value);
            current = current.Next;
        }
        while (!ReferenceEquals(current, start));

        while (stack.Count > 0)
        {
            yield return stack.Pop();
        }
    }
}
