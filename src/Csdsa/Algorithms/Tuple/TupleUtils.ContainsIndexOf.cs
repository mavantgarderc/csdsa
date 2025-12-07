namespace Csdsa.Algorithms.Tuples;

public static partial class TupleUtils
{
    /// <summary>
    /// Determines whether the specified value is equal to either element of the value tuple.
    /// </summary>
    /// <typeparam name="T1">The type of the first element.</typeparam>
    /// <typeparam name="T2">The type of the second element.</typeparam>
    /// <param name="tuple">The value tuple to inspect.</param>
    /// <param name="value">The value to compare with the tuple elements.</param>
    /// <returns>
    /// <see langword="true"/> if <paramref name="value"/> equals <c>First</c> or <c>Second</c>;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    public static bool Contains<T1, T2>(this (T1 First, T2 Second) tuple, object value)
    {
        return Equals(tuple.First, value) || Equals(tuple.Second, value);
    }

    /// <summary>
    /// Returns the zero-based index of the first element in the value tuple that is equal
    /// to the specified value, or -1 if neither element is equal.
    /// </summary>
    /// <typeparam name="T1">The type of the first element.</typeparam>
    /// <typeparam name="T2">The type of the second element.</typeparam>
    /// <param name="tuple">The value tuple to inspect.</param>
    /// <param name="value">The value to compare with the tuple elements.</param>
    /// <returns>
    /// 0 if <paramref name="value"/> equals <c>First</c>;
    /// 1 if it equals <c>Second</c>;
    /// otherwise, -1.
    /// </returns>
    public static int IndexOf<T1, T2>(this (T1 First, T2 Second) tuple, object value)
    {
        if (Equals(tuple.First, value))
        {
            return 0;
        }

        if (Equals(tuple.Second, value))
        {
            return 1;
        }

        return -1;
    }
}
