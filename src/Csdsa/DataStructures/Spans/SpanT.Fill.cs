namespace Csdsa.DataStructures.Spans;

/// <summary>
/// Provides methods for filling spans with values.
/// </summary>
public static partial class SpanT
{
    /// <summary>
    /// Fills the specified span with the given value.
    /// </summary>
    /// <typeparam name="T">The element type of the span.</typeparam>
    /// <param name="span">The span to fill.</param>
    /// <param name="value">The value to assign to each element.</param>
    public static void Fill<T>(Span<T> span, T value)
    {
        span.Fill(value);
    }
}
