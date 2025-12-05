using System.Diagnostics.CodeAnalysis;

namespace Csdsa.DataStructures.Lists;

/// <summary>
/// Provides utility methods for working with <see cref="List{T}"/> instances.
/// <para>
/// Concepts:
/// </para>
/// <list type="bullet">
///   <item>
///     <description>
///     Generic collections and the <c>System.Collections.Generic</c> namespace.
///     </description>
///   </item>
///   <item>
///     <description>
///     <see cref="List{T}"/> instantiation, manipulation, and iteration.
///     </description>
///   </item>
///   <item>
///     <description>
///     Functional programming with lambda expressions over lists.
///     </description>
///   </item>
///   <item>
///     <description>
///     Data querying patterns commonly used with LINQ.
///     </description>
///   </item>
/// </list>
/// <para>
/// Key practices illustrated:
/// </para>
/// <list type="bullet">
///   <item>
///     <description>Avoiding index out-of-range errors by validating indices.</description>
///   </item>
///   <item>
///     <description>Using collection APIs such as <see cref="ICollection{T}.Add(T)"/> and <see cref="IList{T}.RemoveAt(int)"/> responsibly.</description>
///   </item>
///   <item>
///     <description>
///     Leveraging search and sort APIs for clear and efficient data manipulation.
///     </description>
///   </item>
///   <item>
///     <description>
///     Combining sorting, reversing, and LINQ-style operations
///     for readable data transformations.
///     </description>
///   </item>
/// </list>
/// </summary>
[SuppressMessage(
    "Usage",
    "CA1510:Use ArgumentNullException.ThrowIfNull",
    Justification = "Project uses <Nullable>disable; explicit null checks are clearer and avoid conflicts with CA2264.")]
public static partial class ListT
{
}
