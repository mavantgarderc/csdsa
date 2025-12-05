namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="AddRange(System.Collections.Generic.IEnumerable{T})"/> method
/// for <see cref="DoublyLinkedList{T}"/>.
/// </summary>
public partial class DoublyLinkedList<T>
{
    /// <inheritdoc />
    public void AddRange(IEnumerable<T> items)
    {
        ArgumentNullException.ThrowIfNull(items);

        foreach (T item in items)
        {
            AddLast(item);
        }
    }
}
