using System.Collections.Generic;

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
///     <description>Using <see cref="List{T}.AddRange(System.Collections.Generic.IEnumerable{T})"/> and <see cref="List{T}.RemoveAt(int)"/> responsibly.</description>
///   </item>
///   <item>
///     <description>
///     Leveraging <see cref="List{T}.FindAll(System.Predicate{T})"/> and <see cref="List{T}.Contains(T)"/> for clear search logic.
///     </description>
///   </item>
///   <item>
///     <description>
///     Combining <see cref="List{T}.Sort()"/>, <see cref="List{T}.Reverse()"/>, and LINQ-style operations
///     for readable data transformations.
///     </description>
///   </item>
/// </list>
/// </summary>
public static partial class ListT
{
}
