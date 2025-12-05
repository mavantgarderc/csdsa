namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Represents a generic graph with weighted edges, using adjacency lists.
/// <para>
/// Concepts:
/// </para>
/// <list type="bullet">
///   <item>
///     <description>
///     Graph representation via adjacency lists, optimized for sparse graphs.
///     </description>
///   </item>
///   <item>
///     <description>
///     Supports multiple algorithmic families: traversals, path finding,
///     cycle detection, connectivity, minimum spanning trees, and more.
///     </description>
///   </item>
///   <item>
///     <description>
///     Can operate as directed or undirected depending on configuration.
///     </description>
///   </item>
///   <item>
///     <description>
///     Provides building blocks for higher-level algorithms
///     (BFS, DFS, Dijkstra, Bellman–Ford, A*, MST, etc.).
///     </description>
///   </item>
/// </list>
/// <para>
/// Key practices:
/// </para>
/// <list type="bullet">
///   <item>
///     <description>Encapsulation of adjacency lists behind methods and read-only views.</description>
///   </item>
///   <item>
///     <description>Self-contained methods for individual algorithms.</description>
///   </item>
///   <item>
///     <description>
///     Clear exception behavior for error conditions (for example, impossible colorings,
///     negative cycles).
///     </description>
///   </item>
///   <item>
///     <description>
///     Forward-looking design that can be extended with advanced algorithms
///     such as flows or centroid decompositions.
///     </description>
///   </item>
///   <item>
///     <description>Generic support and serialization helpers.</description>
///   </item>
/// </list>
/// </summary>
/// <typeparam name="T">
/// The vertex type. Vertices must be comparable and equatable
/// to support ordering and dictionary keys.
/// </typeparam>
public partial class Graph<T>
    where T : IComparable<T>, IEquatable<T>
{
    /// <summary>
    /// Adjacency list: for each vertex, stores the neighbors and edge weights.
    /// </summary>
    private readonly Dictionary<T, List<(T Vertex, int Weight)>> _adj =
        new Dictionary<T, List<(T Vertex, int Weight)>>();

    private int? _cachedVertexCount;
    private bool _isDirty = true;

    /// <summary>
    /// Gets a value indicating whether the graph is directed.
    /// </summary>
    public bool IsDirected { get; private set; } = true;

    /// <summary>
    /// Initializes a new instance of the <see cref="Graph{T}"/> class.
    /// </summary>
    /// <param name="isDirected">
    /// <see langword="true"/> to create a directed graph; <see langword="false"/> for undirected.
    /// </param>
    public Graph(bool isDirected = true)
    {
        IsDirected = isDirected;
    }
}
