namespace Csdsa.Algorithms.Tuples;

public static partial class TupleUtils
{
    /// <summary>
    /// Flattens a nested value tuple <c>((T1, T2), T3)</c> into a 3-tuple <c>(T1, T2, T3)</c>.
    /// </summary>
    /// <typeparam name="T1">The type of the first element.</typeparam>
    /// <typeparam name="T2">The type of the second element.</typeparam>
    /// <typeparam name="T3">The type of the third element.</typeparam>
    /// <param name="tuple">The nested value tuple to flatten.</param>
    /// <returns>A flattened value tuple <c>(T1, T2, T3)</c>.</returns>
    public static (T1 First, T2 Second, T3 Third) Flatten<T1, T2, T3>(
        this ((T1 First, T2 Second) Inner, T3 Third) tuple)
    {
        return (tuple.Inner.First, tuple.Inner.Second, tuple.Third);
    }

    /// <summary>
    /// Flattens a nested reference tuple <c>Tuple&lt;Tuple&lt;T1, T2&gt;, T3&gt;</c>
    /// into a 3-tuple <see cref="Tuple{T1, T2, T3}"/>.
    /// </summary>
    /// <typeparam name="T1">The type of the first element.</typeparam>
    /// <typeparam name="T2">The type of the second element.</typeparam>
    /// <typeparam name="T3">The type of the third element.</typeparam>
    /// <param name="tuple">The nested reference tuple to flatten.</param>
    /// <returns>A flattened <see cref="Tuple{T1, T2, T3}"/>.</returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="tuple"/> or <paramref name="tuple.Item1"/> is <see langword="null"/>.
    /// </exception>
    public static Tuple<T1, T2, T3> Flatten<T1, T2, T3>(this Tuple<Tuple<T1, T2>, T3> tuple)
    {
        ArgumentNullException.ThrowIfNull(tuple);
        ArgumentNullException.ThrowIfNull(tuple.Item1);

        return new Tuple<T1, T2, T3>(tuple.Item1.Item1, tuple.Item1.Item2, tuple.Item2);
    }
}
