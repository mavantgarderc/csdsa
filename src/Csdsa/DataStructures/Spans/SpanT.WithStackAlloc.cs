using System.Diagnostics.CodeAnalysis;

namespace Csdsa.DataStructures.Spans;

/// <summary>
/// Provides helpers for working with stack-allocated spans.
/// </summary>
public static partial class SpanT
{
    /// <summary>
    /// Allocates a span of the specified size on the stack and invokes the provided action
    /// with that span.
    /// </summary>
    /// <param name="size">
    /// The number of elements to allocate. Must be between 1 and 1024 (inclusive).
    /// </param>
    /// <param name="action">
    /// The action to perform with the allocated span.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="size"/> is less than or equal to zero, or greater than 1024.
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="action"/> is <see langword="null"/>.
    /// </exception>
    [SuppressMessage(
        "Usage",
        "CA1510:Use ArgumentNullException.ThrowIfNull",
        Justification = "Explicit null checks are clearer with <Nullable>disable and avoid CA2264 conflicts.")]
    public static void WithStackAlloc(int size, Action<Span<int>> action)
    {
        if (size <= 0 || size > 1024)
        {
            throw new ArgumentOutOfRangeException(
                nameof(size),
                "Size must be between 1 and 1024.");
        }

        if (action == null)
        {
            throw new ArgumentNullException(nameof(action));
        }

        Span<int> buffer = stackalloc int[size];
        action(buffer);
    }
}
