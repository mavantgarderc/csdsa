namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="HasCycle"/> method for <see cref="CircularLinkedList{T}"/>.
/// </summary>
public partial class CircularLinkedList<T>
{
    /// <inheritdoc />
    public bool HasCycle()
    {
        // By design, this implementation always represents a circular list.
        return true;
    }
}
