namespace Csdsa.Algorithms.GraphTraversal;

/// <summary>
/// Provides depth-first search (DFS) algorithms and utilities for graphs.
/// <para>
/// Concepts:
/// </para>
/// <list type="bullet">
///   <item>
///     <description>
///     Graph traversal using DFS in both iterative (stack-based) and recursive forms.
///     </description>
///   </item>
///   <item>
///     <description>
///     Path existence queries and enumeration of all simple paths between vertices.
///     </description>
///   </item>
///   <item>
///     <description>
///     Cycle detection in both directed and undirected graphs.
///     </description>
///   </item>
///   <item>
///     <description>
///     Topological sorting of directed acyclic graphs (DAGs) using DFS postorder.
///     </description>
///   </item>
///   <item>
///     <description>
///     Connected components discovery in undirected graphs via repeated DFS.
///     </description>
///   </item>
/// </list>
/// <para>
/// Key practices supported by this module include:
/// </para>
/// <list type="bullet">
///   <item>
///     <description>Use of an explicit <see cref="System.Collections.Generic.Stack{T}"/> for iterative DFS.</description>
///   </item>
///   <item>
///     <description>Visited node tracking to avoid cycles and redundant work.</description>
///   </item>
///   <item>
///     <description>Early termination when a predicate or goal condition is met.</description>
///   </item>
///   <item>
///     <description>
///     Depth management for path-based problems and bounding recursion or search depth.
///     </description>
///   </item>
///   <item>
///     <description>Both recursive and iterative DFS paradigms for didactic comparison.</description>
///   </item>
/// </list>
/// </summary>
public static partial class Dfs
{
}
