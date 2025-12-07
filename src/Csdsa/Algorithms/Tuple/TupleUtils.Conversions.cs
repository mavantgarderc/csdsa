namespace Csdsa.Algorithms.Tuples;

public static partial class TupleUtils
{
    /// <summary>
    /// Converts the specified <see cref="Tuple{T1, T2}"/> to a value tuple.
    /// </summary>
    /// <typeparam name="T1">The type of the first element.</typeparam>
    /// <typeparam name="T2">The type of the second element.</typeparam>
    /// <param name="tuple">The reference tuple to convert.</param>
    /// <returns>A value tuple containing the same elements as <paramref name="tuple"/>.</returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="tuple"/> is <see langword="null"/>.
    /// </exception>
    public static (T1 First, T2 Second) ToValueTuple<T1, T2>(this Tuple<T1, T2> tuple)
    {
        ArgumentNullException.ThrowIfNull(tuple);

        return (tuple.Item1, tuple.Item2);
    }

    /// <summary>
    /// Converts the specified value tuple to a <see cref="Tuple{T1, T2}"/>.
    /// </summary>
    /// <typeparam name="T1">The type of the first element.</typeparam>
    /// <typeparam name="T2">The type of the second element.</typeparam>
    /// <param name="valueTuple">The value tuple to convert.</param>
    /// <returns>
    /// A new <see cref="Tuple{T1, T2}"/> containing the same elements as <paramref name="valueTuple"/>.
    /// </returns>
    public static Tuple<T1, T2> ToTuple<T1, T2>(this (T1 First, T2 Second) valueTuple)
    {
        return new Tuple<T1, T2>(valueTuple.First, valueTuple.Second);
    }
}
