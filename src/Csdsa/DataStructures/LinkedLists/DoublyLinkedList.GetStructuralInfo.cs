namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="ILinkedList{T}.GetStructuralInfo"/> implementation
/// for <see cref="DoublyLinkedList{T}"/>.
/// </summary>
public partial class DoublyLinkedList<T>
{
    /// <inheritdoc />
    public (int Length, int MidIndex) GetStructuralInfo()
    {
        if (_head == null)
        {
            return (0, -1);
        }

        LinkedListNode<T> slow = _head;
        LinkedListNode<T> fast = _head;
        int index = 0;

        while (fast != null && fast.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;
            index++;
        }

        return (_count, index);
    }
}
