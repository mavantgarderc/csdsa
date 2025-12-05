namespace Csdsa.DataStructures.Spans;

/// <summary>
/// Provides helpers for extracting middle slices from spans.
/// </summary>
public static partial class SpanT
{
    /// <summary>
    /// Returns a slice containing the middle one or two elements of the span.
    /// </summary>
    /// <typeparam name="T">The element type of the span.</typeparam>
    /// <param name="span">The span to slice.</param>
    /// <returns>
    /// A slice containing the single middle element for odd-length spans, or the two
    /// middle elements for even-length spans.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="span"/> is empty.
    /// </exception>
    public static Span<T> SliceMiddle<T>(Span<T> span)
    {
        if (span.IsEmpty)
        {
            throw new ArgumentOutOfRangeException(nameof(span), "Span cannot be empty.");
        }

        int start;
        int length;

        if (span.Length % 2 == 0)
        {
            start = (span.Length / 2) - 1;
            length = 2;
        }
        else
        {
            start = span.Length / 2;
            length = 1;
        }

        return span.Slice(start, length);
    }
}
