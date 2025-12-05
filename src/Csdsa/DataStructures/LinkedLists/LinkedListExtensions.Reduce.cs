namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <c>Reduce</c> extension for <see cref="ILinkedList{T}"/>.
/// </summary>
public static partial class LinkedListExtensions
{
    /// <summary>
    /// Aggregates the elements of the list using the specified seed value and accumulator function.
    /// </summary>
    /// <typeparam name="T">The element type.</typeparam>
    /// <typeparam name="TResult">The result type.</typeparam>
    /// <param name="list">The list whose elements to aggregate.</param>
    /// <param name="seed">The initial accumulator value.</param>
    /// <param name="accumulator">
    /// A function that updates the accumulator with each element.
    /// </param>
    /// <returns>The final accumulator value.</returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="list"/> or <paramref name="accumulator"/> is null.
    /// </exception>
    public static TResult Reduce<T, TResult>(
        this ILinkedList<T> list,
        TResult seed,
        Func<TResult, T, TResult> accumulator)
    {
        if (list == null)
        {
            ArgumentNullException.ThrowIfNull(list);
        }

        if (accumulator == null)
        {
            ArgumentNullException.ThrowIfNull(accumulator);
        }

        TResult result = seed;

        foreach (T item in list)
        {
            result = accumulator(result, item);
        }

        return result;
    }
}
