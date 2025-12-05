namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Provides the <see cref="EdgeCount"/> property for <see cref="Graph{T}"/>.
/// </summary>
public partial class Graph<T>
    where T : System.IComparable<T>, System.IEquatable<T>
{
    /// <summary>
    /// Gets the number of edges in the graph.
    /// </summary>
    public int EdgeCount
    {
        get
        {
            int total = _adj.Values.Sum(list => list.Count);
            return IsDirected ? total : total / 2;
        }
    }
}
