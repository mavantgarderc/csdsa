namespace Csdsa.Algorithms.Tuples;

public static partial class TupleUtils
{
    /// <summary>
    /// Applies the specified action to the elements of a value tuple.
    /// </summary>
    /// <typeparam name="T1">The type of the first element.</typeparam>
    /// <typeparam name="T2">The type of the second element.</typeparam>
    /// <param name="tuple">The value tuple whose elements to pass to the action.</param>
    /// <param name="action">The action to apply to the elements.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="action"/> is <see langword="null"/>.
    /// </exception>
    public static void Apply<T1, T2>((T1 First, T2 Second) tuple, Action<T1, T2> action)
    {
        ArgumentNullException.ThrowIfNull(action);

        action(tuple.First, tuple.Second);
    }

    /// <summary>
    /// Projects the elements of a value tuple into a single result value using
    /// the specified selector function.
    /// </summary>
    /// <typeparam name="T1">The type of the first element.</typeparam>
    /// <typeparam name="T2">The type of the second element.</typeparam>
    /// <typeparam name="TResult">The result type.</typeparam>
    /// <param name="tuple">The value tuple whose elements to project.</param>
    /// <param name="selector">A function that produces the result value from the tuple elements.</param>
    /// <returns>The result of invoking <paramref name="selector"/> on the tuple elements.</returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="selector"/> is <see langword="null"/>.
    /// </exception>
    public static TResult Select<T1, T2, TResult>(
        (T1 First, T2 Second) tuple,
        Func<T1, T2, TResult> selector)
    {
        ArgumentNullException.ThrowIfNull(selector);

        return selector(tuple.First, tuple.Second);
    }

    /// <summary>
    /// Applies the same mapping function to both elements of a 2-tuple
    /// <c>(T1, T1)</c> to produce a new value tuple <c>(TResult, TResult)</c>.
    /// </summary>
    /// <typeparam name="T1">The source element type.</typeparam>
    /// <typeparam name="TResult">The result element type.</typeparam>
    /// <param name="tuple">The source value tuple.</param>
    /// <param name="map">The mapping function to apply to both elements.</param>
    /// <returns>
    /// A new value tuple whose elements are the results of applying <paramref name="map"/>
    /// to the elements of <paramref name="tuple"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="map"/> is <see langword="null"/>.
    /// </exception>
    public static (TResult First, TResult Second) TransformAll<T1, TResult>(
        (T1 First, T1 Second) tuple,
        Func<T1, TResult> map)
    {
        ArgumentNullException.ThrowIfNull(map);

        return (map(tuple.First), map(tuple.Second));
    }
}
