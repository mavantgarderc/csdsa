namespace Csdsa.Algorithms.Tuples;

public static partial class TupleUtils
{
    /// <summary>
    /// Zips two sequences into a sequence of value tuples.
    /// </summary>
    /// <typeparam name="T1">The element type of the first sequence.</typeparam>
    /// <typeparam name="T2">The element type of the second sequence.</typeparam>
    /// <param name="first">The first sequence to zip.</param>
    /// <param name="second">The second sequence to zip.</param>
    /// <returns>
    /// A sequence of value tuples, where each value tuple contains the elements from the input
    /// sequences at the corresponding position.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="first"/> or <paramref name="second"/> is <see langword="null"/>.
    /// </exception>
    public static IEnumerable<(T1 First, T2 Second)> ZipToValueTuples<T1, T2>(
        IEnumerable<T1> first,
        IEnumerable<T2> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        ArgumentNullException.ThrowIfNull(second);

        return first.Zip(second, (a, b) => (a, b));
    }

    /// <summary>
    /// Zips two sequences into a sequence of <see cref="Tuple{T1, T2}"/> instances.
    /// </summary>
    /// <typeparam name="T1">The element type of the first sequence.</typeparam>
    /// <typeparam name="T2">The element type of the second sequence.</typeparam>
    /// <param name="first">The first sequence to zip.</param>
    /// <param name="second">The second sequence to zip.</param>
    /// <returns>
    /// A sequence of <see cref="Tuple{T1, T2}"/>, where each tuple contains the elements
    /// from the input sequences at the corresponding position.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="first"/> or <paramref name="second"/> is <see langword="null"/>.
    /// </exception>
    public static IEnumerable<Tuple<T1, T2>> ZipToTuples<T1, T2>(
        IEnumerable<T1> first,
        IEnumerable<T2> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        ArgumentNullException.ThrowIfNull(second);

        return first.Zip(second, (a, b) => new Tuple<T1, T2>(a, b));
    }
}
