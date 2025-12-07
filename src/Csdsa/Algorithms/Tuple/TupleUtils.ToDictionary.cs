namespace Csdsa.Algorithms.Tuples;

public static partial class TupleUtils
{
    /// <summary>
    /// Projects a sequence of value tuples into a <see cref="Dictionary{TKey, TValue}"/>.
    /// </summary>
    /// <typeparam name="T1">
    /// The type of the key element. Must be non-nullable to be used as a dictionary key.
    /// </typeparam>
    /// <typeparam name="T2">The type of the value element.</typeparam>
    /// <param name="tuples">The sequence of value tuples to project.</param>
    /// <param name="throwIfNull">
    /// If <see langword="true"/>, throws when a value tuple contains a <see langword="null"/> value element;
    /// otherwise allows <see langword="null"/> values in the resulting dictionary.
    /// </param>
    /// <returns>
    /// A <see cref="Dictionary{TKey, TValue}"/> populated from <paramref name="tuples"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="tuples"/> is <see langword="null"/>.
    /// </exception>
    /// <exception cref="InvalidOperationException">
    /// Thrown when <paramref name="throwIfNull"/> is <see langword="true"/> and a tuple's value element is null.
    /// </exception>
    public static Dictionary<T1, T2> ToDictionary<T1, T2>(
        this IEnumerable<(T1 Key, T2 Value)> tuples,
        bool throwIfNull = false)
        where T1 : notnull
    {
        ArgumentNullException.ThrowIfNull(tuples);

        if (throwIfNull)
        {
            return tuples.ToDictionary(
                t => t.Key,
                t => t.Value is null
                    ? throw new InvalidOperationException("Tuple.Item2 is null.")
                    : t.Value);
        }

        return tuples.ToDictionary(t => t.Key, t => t.Value);
    }
}
