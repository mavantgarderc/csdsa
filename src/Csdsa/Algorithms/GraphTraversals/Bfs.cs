namespace Csdsa.Algorithms.GraphTraversal;

/// <summary>
/// Provides breadth-first search (BFS) algorithms and utilities for graphs and grids.
/// <para>
/// Concepts:
/// </para>
/// <list type="bullet">
///   <item>
///     <description>
///     BFS explores a graph in layers (levels), visiting all neighbors
///     of a vertex before moving to the next layer.
///     </description>
///   </item>
///   <item>
///     <description>
///     In unweighted graphs, BFS computes shortest path distances
///     (minimum number of edges) from a source to all reachable vertices.
///     </description>
///   </item>
///   <item>
///     <description>
///     BFS relies on a queue (FIFO) and a visited set/array to prevent
///     revisiting vertices and to avoid infinite loops in cyclic graphs.
///     </description>
///   </item>
///   <item>
///     <description>
///     Many grid-based problems (shortest path in a maze, counting islands,
///     knight moves on a chessboard) can be modeled as BFS on an implicit graph.
///     </description>
///   </item>
///   <item>
///     <description>
///     Predicate-based BFS allows early termination when a goal condition
///     is satisfied (e.g., first node that matches a predicate).
///     </description>
///   </item>
/// </list>
/// <para>
/// Key practices supported by this module include:
/// </para>
/// <list type="bullet">
///   <item>
///     <description>Computing single-source and multi-source shortest paths in unweighted graphs.</description>
///   </item>
///   <item>
///     <description>Detecting cycles in undirected graphs using BFS.</description>
///   </item>
///   <item>
///     <description>Performing topological sort of DAGs using Kahn's algorithm.</description>
///   </item>
///   <item>
///     <description>Counting connected components via repeated BFS from unvisited vertices.</description>
///   </item>
///   <item>
///     <description>Solving classic problems such as word ladders, island counting,
///     grid shortest paths, and knight moves using BFS on implicit graphs.</description>
///   </item>
/// </list>
/// </summary>
public static partial class Bfs
{
}
