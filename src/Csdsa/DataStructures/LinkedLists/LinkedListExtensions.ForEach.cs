namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <c>ForEach</c> extension for <see cref="ILinkedList{T}"/>.
/// </summary>
public static partial class LinkedListExtensions
{
    /// <summary>
    /// Performs the specified action on each element of the list.
    /// </summary>
    /// <typeparam name="T">The element type.</typeparam>
    /// <param name="list">The list whose elements to process.</param>
    /// <param name="action">The action to perform on each element.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="list"/> or <paramref name="action"/> is null.
    /// </exception>
    public static void ForEach<T>(
        this ILinkedList<T> list,
        Action<T> action)
    {
        if (list == null)
        {
            ArgumentNullException.ThrowIfNull(list);
        }

        if (action == null)
        {
            ArgumentNullException.ThrowIfNull(action);
        }

        foreach (T item in list)
        {
            action(item);
        }
    }
}
