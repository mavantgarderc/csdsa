namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="ILinkedList{T}.GetStructuralInfo"/> implementation
/// for <see cref="CircularLinkedList{T}"/>.
/// </summary>
public partial class CircularLinkedList<T>
{
    /// <inheritdoc />
    public (int Length, int MidIndex) GetStructuralInfo()
    {
        if (_tail == null)
        {
            return (0, -1);
        }

        SinglyLinkedListNode<T> slow = Head;
        SinglyLinkedListNode<T> fast = Head;
        int index = 0;

        for (int i = 0; i < _count / 2; i++)
        {
            slow = slow.Next;
            fast = fast.Next.Next;
            index++;
        }

        return (_count, index);
    }
}
