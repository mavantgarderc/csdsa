namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="HasCycle"/> method for <see cref="DoublyLinkedList{T}"/>.
/// </summary>
public partial class DoublyLinkedList<T>
{
    /// <inheritdoc />
    public bool HasCycle()
    {
        if (_head == null)
        {
            return false;
        }

        LinkedListNode<T> slow = _head;
        LinkedListNode<T> fast = _head;

        while (fast != null && fast.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;

            if (ReferenceEquals(slow, fast))
            {
                return true;
            }
        }

        return false;
    }
}
