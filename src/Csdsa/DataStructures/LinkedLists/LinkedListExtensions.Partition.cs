namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <c>Partition</c> extension for <see cref="ILinkedList{T}"/>.
/// </summary>
public static partial class LinkedListExtensions
{
    /// <summary>
    /// Partitions the elements of the list into two linked lists based on a predicate.
    /// </summary>
    /// <typeparam name="T">The element type.</typeparam>
    /// <param name="list">The list to partition.</param>
    /// <param name="predicate">The predicate used to partition elements.</param>
    /// <returns>
    /// A tuple where <c>Matches</c> contains elements that satisfy the predicate and
    /// <c>NonMatches</c> contains elements that do not.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="list"/> or <paramref name="predicate"/> is null.
    /// </exception>
    public static (ILinkedList<T> Matches, ILinkedList<T> NonMatches) Partition<T>(
        this ILinkedList<T> list,
        Func<T, bool> predicate)
    {
        if (list == null)
        {
            ArgumentNullException.ThrowIfNull(list);
        }

        if (predicate == null)
        {
            ArgumentNullException.ThrowIfNull(predicate);
        }

        DoublyLinkedList<T> matches = new DoublyLinkedList<T>();
        DoublyLinkedList<T> nonMatches = new DoublyLinkedList<T>();

        foreach (T item in list)
        {
            if (predicate(item))
            {
                matches.AddLast(item);
            }
            else
            {
                nonMatches.AddLast(item);
            }
        }

        return (Matches: matches, NonMatches: nonMatches);
    }
}
