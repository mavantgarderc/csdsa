namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <c>Map</c> extension for <see cref="ILinkedList{T}"/>.
/// </summary>
public static partial class LinkedListExtensions
{
    /// <summary>
    /// Projects each element of the linked list into a new form.
    /// </summary>
    /// <typeparam name="T">The source element type.</typeparam>
    /// <typeparam name="TResult">The result element type.</typeparam>
    /// <param name="list">The list whose elements to transform.</param>
    /// <param name="selector">A transform function to apply to each element.</param>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> whose elements are the result of
    /// invoking the transform function on each element of the source list.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="list"/> or <paramref name="selector"/> is null.
    /// </exception>
    public static IEnumerable<TResult> Map<T, TResult>(
        this ILinkedList<T> list,
        Func<T, TResult> selector)
    {
        if (selector == null)
        {
            ArgumentNullException.ThrowIfNull(selector);
        }

        if (list == null)
        {
            ArgumentNullException.ThrowIfNull(list);
        }

        foreach (T item in list)
        {
            yield return selector(item);
        }
    }
}
