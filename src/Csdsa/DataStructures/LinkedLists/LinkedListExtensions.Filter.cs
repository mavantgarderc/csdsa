namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <c>Filter</c> extension for <see cref="ILinkedList{T}"/>.
/// </summary>
public static partial class LinkedListExtensions
{
    /// <summary>
    /// Filters the elements of the list based on a predicate.
    /// </summary>
    /// <typeparam name="T">The element type.</typeparam>
    /// <param name="list">The list to filter.</param>
    /// <param name="predicate">A function to test each element for a condition.</param>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> that contains elements from the input list
    /// that satisfy the condition.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="list"/> or <paramref name="predicate"/> is null.
    /// </exception>
    public static IEnumerable<T> Filter<T>(
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

        foreach (T item in list)
        {
            if (predicate(item))
            {
                yield return item;
            }
        }
    }
}
