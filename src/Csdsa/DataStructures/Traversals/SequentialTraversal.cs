using System.Diagnostics.CodeAnalysis;

namespace Csdsa.DataStructures.Traversals;

/// <summary>
/// Provides example traversal routines for common .NET collection types.
/// <para>
/// Concepts:
/// </para>
/// <list type="bullet">
///   <item>
///     <description>
///     Sequential and parallel traversal of standard collections.
///     </description>
///   </item>
///   <item>
///     <description>
///     Generic programming for type flexibility.
///     </description>
///   </item>
///   <item>
///     <description>
///     Iteration over linear and non-linear data structures such as arrays,
///     stacks, queues, linked lists, dictionaries, and sets.
///     </description>
///   </item>
///   <item>
///     <description>
///     Handling specialized structures including jagged arrays, multidimensional
///     arrays, spans, and circular buffers.
///     </description>
///   </item>
/// </list>
/// <para>
/// Key practices:
/// </para>
/// <list type="bullet">
///   <item>
///     <description>
///     Using appropriate iteration patterns for each collection type.
///     </description>
///   </item>
///   <item>
///     <description>
///     Leveraging interfaces such as <see cref="IEnumerable{T}"/> and <see cref="IList{T}"/>
///     for abstraction.
///     </description>
///   </item>
///   <item>
///     <description>
///     Demonstrating both forward and reverse traversal techniques.
///     </description>
///   </item>
///   <item>
///     <description>
///     Showing safe and efficient use of enumerators and parallel traversal APIs.
///     </description>
///   </item>
/// </list>
/// </summary>
[SuppressMessage(
    "Usage",
    "CA1510:Use ArgumentNullException.ThrowIfNull",
    Justification = "Project uses <Nullable>disable; explicit null checks are clearer and avoid conflicts with CA2264.")]
public static partial class SequentialTraversal
{
}
