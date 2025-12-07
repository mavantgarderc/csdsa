namespace Csdsa.Algorithms.Tuples;

public static partial class TupleUtils
{
    /// <summary>
    /// Swaps the elements of a value tuple <c>(T1, T2)</c> to produce <c>(T2, T1)</c>.
    /// </summary>
    /// <typeparam name="T1">The type of the first element.</typeparam>
    /// <typeparam name="T2">The type of the second element.</typeparam>
    /// <param name="tuple">The value tuple whose elements to swap.</param>
    /// <returns>A new value tuple with the elements swapped.</returns>
    public static (T2 Second, T1 First) Swap<T1, T2>(this (T1 First, T2 Second) tuple)
    {
        return (tuple.Second, tuple.First);
    }

    /// <summary>
    /// Swaps the elements of a <see cref="Tuple{T1, T2}"/> to produce a
    /// <see cref="Tuple{T1, T2}"/> with reversed element order.
    /// </summary>
    /// <typeparam name="T1">The type of the first element.</typeparam>
    /// <typeparam name="T2">The type of the second element.</typeparam>
    /// <param name="tuple">The reference tuple whose elements to swap.</param>
    /// <returns>A new <see cref="Tuple{T1, T2}"/> with reversed element order.</returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="tuple"/> is <see langword="null"/>.
    /// </exception>
    public static Tuple<T2, T1> Swap<T1, T2>(this Tuple<T1, T2> tuple)
    {
        ArgumentNullException.ThrowIfNull(tuple);

        return new Tuple<T2, T1>(tuple.Item2, tuple.Item1);
    }
}
