namespace Csdsa.Algorithms.Tuples;

public static partial class TupleUtils
{
    /// <summary>
    /// Creates a new <see cref="Tuple{T1, T2}"/> instance with the specified elements.
    /// </summary>
    /// <typeparam name="T1">The type of the first element.</typeparam>
    /// <typeparam name="T2">The type of the second element.</typeparam>
    /// <param name="item1">The first element.</param>
    /// <param name="item2">The second element.</param>
    /// <returns>A new <see cref="Tuple{T1, T2}"/> containing the specified elements.</returns>
    public static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2)
    {
        return new Tuple<T1, T2>(item1, item2);
    }

    /// <summary>
    /// Creates a new value tuple with the specified elements.
    /// </summary>
    /// <typeparam name="T1">The type of the first element.</typeparam>
    /// <typeparam name="T2">The type of the second element.</typeparam>
    /// <param name="item1">The first element.</param>
    /// <param name="item2">The second element.</param>
    /// <returns>A value tuple containing the specified elements.</returns>
    public static (T1 First, T2 Second) CreateValueTuple<T1, T2>(T1 item1, T2 item2)
    {
        return (item1, item2);
    }
}
