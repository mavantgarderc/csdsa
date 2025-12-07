namespace Csdsa.Algorithms.Tuples;

public static partial class TupleUtils
{
    /// <summary>
    /// Projects the elements of a value tuple into a new value tuple by applying
    /// separate mapping functions to each element.
    /// </summary>
    /// <typeparam name="T1">The type of the first source element.</typeparam>
    /// <typeparam name="T2">The type of the second source element.</typeparam>
    /// <typeparam name="TResult1">The type of the first result element.</typeparam>
    /// <typeparam name="TResult2">The type of the second result element.</typeparam>
    /// <param name="tuple">The source value tuple.</param>
    /// <param name="map1">The mapping function for the first element.</param>
    /// <param name="map2">The mapping function for the second element.</param>
    /// <returns>
    /// A value tuple whose elements are the results of applying <paramref name="map1"/>
    /// and <paramref name="map2"/> to the elements of <paramref name="tuple"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="map1"/> or <paramref name="map2"/> is <see langword="null"/>.
    /// </exception>
    public static (TResult1 First, TResult2 Second) Map<T1, T2, TResult1, TResult2>(
        this (T1 First, T2 Second) tuple,
        Func<T1, TResult1> map1,
        Func<T2, TResult2> map2)
    {
        ArgumentNullException.ThrowIfNull(map1);
        ArgumentNullException.ThrowIfNull(map2);

        return (map1(tuple.First), map2(tuple.Second));
    }

    /// <summary>
    /// Projects the elements of a <see cref="Tuple{T1, T2}"/> into a new <see cref="Tuple{T1, T2}"/>
    /// by applying separate mapping functions to each element.
    /// </summary>
    /// <typeparam name="T1">The type of the first source element.</typeparam>
    /// <typeparam name="T2">The type of the second source element.</typeparam>
    /// <typeparam name="TResult1">The type of the first result element.</typeparam>
    /// <typeparam name="TResult2">The type of the second result element.</typeparam>
    /// <param name="tuple">The source reference tuple.</param>
    /// <param name="map1">The mapping function for the first element.</param>
    /// <param name="map2">The mapping function for the second element.</param>
    /// <returns>
    /// A new <see cref="Tuple{T1, T2}"/> whose elements are the results of applying
    /// <paramref name="map1"/> and <paramref name="map2"/> to the elements of
    /// <paramref name="tuple"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="tuple"/>, <paramref name="map1"/>, or <paramref name="map2"/>
    /// is <see langword="null"/>.
    /// </exception>
    public static Tuple<TResult1, TResult2> Map<T1, T2, TResult1, TResult2>(
        this Tuple<T1, T2> tuple,
        Func<T1, TResult1> map1,
        Func<T2, TResult2> map2)
    {
        ArgumentNullException.ThrowIfNull(tuple);
        ArgumentNullException.ThrowIfNull(map1);
        ArgumentNullException.ThrowIfNull(map2);

        return new Tuple<TResult1, TResult2>(map1(tuple.Item1), map2(tuple.Item2));
    }
}
