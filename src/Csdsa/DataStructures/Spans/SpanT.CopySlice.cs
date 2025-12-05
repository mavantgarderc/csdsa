namespace Csdsa.DataStructures.Spans;

/// <summary>
/// Provides slice-copy operations for spans.
/// </summary>
public static partial class SpanT
{
    /// <summary>
    /// Copies the contents of the source span to the destination span.
    /// </summary>
    /// <typeparam name="T">The element type of the spans.</typeparam>
    /// <param name="source">The source span.</param>
    /// <param name="destination">
    /// The destination span. Must be at least as long as <paramref name="source"/>.
    /// </param>
    /// <exception cref="ArgumentException">
    /// Thrown when <paramref name="destination"/> is shorter than <paramref name="source"/>.
    /// </exception>
    public static void CopySlice<T>(Span<T> source, Span<T> destination)
    {
        if (!source.TryCopyTo(destination))
        {
            throw new ArgumentException("Destination span is too small.", nameof(destination));
        }

        // Redundant but matches original behavior: perform the copy explicitly as well.
        source.CopyTo(destination);
    }
}
