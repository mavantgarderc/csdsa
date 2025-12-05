namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="ILinkedList{T}.GetStructuralInfo"/> implementation
/// for <see cref="CircularDoublyLinkedList{T}"/>.
/// </summary>
public partial class CircularDoublyLinkedList<T>
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

        do
        {
            slow = slow.Next;
            fast = fast.Next.Next;
            index++;
        }
        while (!ReferenceEquals(fast, _head) && !ReferenceEquals(fast.Next, _head));

        return (_count, index);
    }
}
