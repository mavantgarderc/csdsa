namespace Csdsa.Algorithms.Search.Linear;

/// <summary>
/// Provides linear search (O(n)) extension methods over <see cref="System.Collections.Generic.IEnumerable{T}"/>.
/// <para>
/// Concepts:
/// </para>
/// <list type="bullet">
///   <item>
///     <description>
///     Generics (<c>T</c>) to enable reusable algorithms across different collection types.
///     </description>
///   </item>
///   <item>
///     <description>
///     Extension methods for enhancing existing types without modifying their original definitions.
///     </description>
///   </item>
///   <item>
///     <description>
///     Higher-order functions (<see cref="System.Func{T,TResult}"/>) for flexible match criteria.
///     </description>
///   </item>
///   <item>
///     <description>
///     Algorithm complexity of linear search and its O(n) performance characteristics.
///     </description>
///   </item>
/// </list>
/// <para>
/// Key practices:
/// </para>
/// <list type="bullet">
///   <item>
///     <description>Implementing extension methods to enhance <see cref="System.Collections.Generic.IEnumerable{T}"/> functionality.</description>
///   </item>
///   <item>
///     <description>Designing generic algorithms for maximum code reuse.</description>
///   </item>
///   <item>
///     <description>
///     Staying type-safe by employing <see cref="System.Func{T,TResult}"/> predicates
///     instead of ad-hoc casting.
///     </description>
///   </item>
///   <item>
///     <description>Maintaining clear semantics for "first", "last", "single", and "all/any" matches.</description>
///   </item>
/// </list>
/// </summary>
public static partial class LinearSearch
{
}
