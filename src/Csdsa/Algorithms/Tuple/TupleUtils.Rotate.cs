namespace Csdsa.Algorithms.Tuples;

public static partial class TupleUtils
{
    /// <summary>
    /// Rotates the elements of a 3-tuple to the left:
    /// <c>(T1, T2, T3) → (T2, T3, T1)</c>.
    /// </summary>
    /// <typeparam name="T1">The type of the first element.</typeparam>
    /// <typeparam name="T2">The type of the second element.</typeparam>
    /// <typeparam name="T3">The type of the third element.</typeparam>
    /// <param name="tuple">The value tuple whose elements to rotate.</param>
    /// <returns>A new value tuple with elements rotated left.</returns>
    public static (T2 Second, T3 Third, T1 First) RotateLeft<T1, T2, T3>(
        (T1 First, T2 Second, T3 Third) tuple)
    {
        return (tuple.Second, tuple.Third, tuple.First);
    }

    /// <summary>
    /// Rotates the elements of a 3-tuple to the right:
    /// <c>(T1, T2, T3) → (T3, T1, T2)</c>.
    /// </summary>
    /// <typeparam name="T1">The type of the first element.</typeparam>
    /// <typeparam name="T2">The type of the second element.</typeparam>
    /// <typeparam name="T3">The type of the third element.</typeparam>
    /// <param name="tuple">The value tuple whose elements to rotate.</param>
    /// <returns>A new value tuple with elements rotated right.</returns>
    public static (T3 Third, T1 First, T2 Second) RotateRight<T1, T2, T3>(
        (T1 First, T2 Second, T3 Third) tuple)
    {
        return (tuple.Third, tuple.First, tuple.Second);
    }
}
