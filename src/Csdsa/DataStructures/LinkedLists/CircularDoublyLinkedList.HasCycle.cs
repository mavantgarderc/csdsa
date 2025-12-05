namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="HasCycle"/> method for <see cref="CircularDoublyLinkedList{T}"/>.
/// </summary>
public partial class CircularDoublyLinkedList<T>
{
    /// <inheritdoc />
    public bool HasCycle()
    {
        // By design, this implementation always represents a circular list.
        return true;
    }
}
