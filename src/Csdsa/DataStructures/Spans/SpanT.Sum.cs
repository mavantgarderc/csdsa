namespace Csdsa.DataStructures.Spans;

/// <summary>
/// Provides aggregation helpers for spans.
/// </summary>
public static partial class SpanT
{
    /// <summary>
    /// Computes the sum of all elements in the specified span.
    /// </summary>
    /// <param name="span">The span whose elements to sum.</param>
    /// <returns>The sum of all elements in the span.</returns>
    public static int Sum(Span<int> span)
    {
        int sum = 0;

        foreach (int num in span)
        {
            sum += num;
        }

        return sum;
    }
}
