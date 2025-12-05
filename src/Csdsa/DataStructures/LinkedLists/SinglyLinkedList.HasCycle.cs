namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="HasCycle"/> method for <see cref="SinglyLinkedList{T}"/>.
/// </summary>
public partial class SinglyLinkedList<T>
{
    /// <inheritdoc />
    public bool HasCycle()
    {
        if (_head == null)
        {
            return false;
        }

        SinglyLinkedListNode<T> slow = _head;
        SinglyLinkedListNode<T> fast = _head;

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
