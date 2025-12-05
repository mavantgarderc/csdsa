namespace Csdsa.DataStructures.Spans;

/// <summary>
/// Provides in-place reversal for spans.
/// </summary>
public static partial class SpanT
{
    /// <summary>
    /// Reverses the contents of the specified span in place.
    /// </summary>
    /// <typeparam name="T">The element type of the span.</typeparam>
    /// <param name="span">The span whose elements should be reversed.</param>
    public static void ReverseInPlace<T>(Span<T> span)
    {
        int i = 0;
        int j = span.Length - 1;

        while (i < j)
        {
            (span[i], span[j]) = (span[j], span[i]);
            i++;
            j--;
        }
    }
}
