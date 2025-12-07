namespace Csdsa.Algorithms.Tuples;

public static partial class TupleUtils
{
    /// <summary>
    /// Determines whether two value tuples are structurally equal using
    /// the default equality comparers for their element types.
    /// </summary>
    /// <typeparam name="T1">The type of the first element.</typeparam>
    /// <typeparam name="T2">The type of the second element.</typeparam>
    /// <param name="a">The first value tuple.</param>
    /// <param name="b">The second value tuple.</param>
    /// <returns>
    /// <see langword="true"/> if both tuples' elements are equal; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool StructuralEquals<T1, T2>(
        (T1 First, T2 Second) a,
        (T1 First, T2 Second) b)
    {
        return EqualityComparer<T1>.Default.Equals(a.First, b.First)
            && EqualityComparer<T2>.Default.Equals(a.Second, b.Second);
    }

    /// <summary>
    /// Determines whether two <see cref="Tuple{T1, T2}"/> instances are structurally equal
    /// using the default equality comparers for their element types.
    /// </summary>
    /// <typeparam name="T1">The type of the first element.</typeparam>
    /// <typeparam name="T2">The type of the second element.</typeparam>
    /// <param name="a">The first reference tuple.</param>
    /// <param name="b">The second reference tuple.</param>
    /// <returns>
    /// <see langword="true"/> if both tuples' elements are equal; otherwise, <see langword="false"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="a"/> or <paramref name="b"/> is <see langword="null"/>.
    /// </exception>
    public static bool StructuralEquals<T1, T2>(Tuple<T1, T2> a, Tuple<T1, T2> b)
    {
        ArgumentNullException.ThrowIfNull(a);
        ArgumentNullException.ThrowIfNull(b);

        return EqualityComparer<T1>.Default.Equals(a.Item1, b.Item1)
            && EqualityComparer<T2>.Default.Equals(a.Item2, b.Item2);
    }
}
