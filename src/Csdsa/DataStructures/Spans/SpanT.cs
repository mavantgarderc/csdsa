namespace Csdsa.DataStructures.Spans;

/// <summary>
/// Provides helper routines for working with <see cref="Span{T}"/> and stack-only memory.
/// <para>
/// Concepts:
/// </para>
/// <list type="bullet">
///   <item>
///     <description>Stack-only memory access.</description>
///   </item>
///   <item>
///     <description>Memory safety without managed heap allocations.</description>
///   </item>
///   <item>
///     <description>
///     Slicing data without copying, via <see cref="Span{T}"/>.
///     </description>
///   </item>
///   <item>
///     <description>Lightweight views over contiguous memory.</description>
///   </item>
/// </list>
/// <para>
/// Key practices:
/// </para>
/// <list type="bullet">
///   <item>
///     <description>
///     Using <see cref="Span{T}"/> for in-place, high-performance operations.
///     </description>
///   </item>
///   <item>
///     <description>Avoiding heap allocations for transient data.</description>
///   </item>
///   <item>
///     <description>Preferring <c>stackalloc</c> when size is small and known.</description>
///   </item>
///   <item>
///     <description><see cref="Span{T}"/> values do not escape the method scope.</description>
///   </item>
/// </list>
/// </summary>
public static partial class SpanT
{
}
