namespace Csdsa.Algorithms.Tuples;

public static partial class TupleUtils
{
    /// <summary>
    /// Duplicates a 2-tuple <c>(T1, T2)</c> into a 4-tuple
    /// <c>(T1, T2, T1, T2)</c>.
    /// </summary>
    /// <typeparam name="T1">The type of the first element.</typeparam>
    /// <typeparam name="T2">The type of the second element.</typeparam>
    /// <param name="tuple">The value tuple to duplicate.</param>
    /// <returns>
    /// A new value tuple whose first two elements are the elements of <paramref name="tuple"/>
    /// followed by those elements again.
    /// </returns>
    public static (T1 First, T2 Second, T1 Third, T2 Fourth) Duplicate<T1, T2>(
        (T1 First, T2 Second) tuple)
    {
        return (tuple.First, tuple.Second, tuple.First, tuple.Second);
    }
}
