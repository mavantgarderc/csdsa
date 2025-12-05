namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Provides the <see cref="VertexCount"/> property for <see cref="Graph{T}"/>.
/// </summary>
public partial class Graph<T>
    where T : System.IComparable<T>, System.IEquatable<T>
{
    /// <summary>
    /// Gets the number of vertices in the graph.
    /// </summary>
    public int VertexCount
    {
        get
        {
            if (_isDirty || !_cachedVertexCount.HasValue)
            {
                _cachedVertexCount = _adj.Count;
                _isDirty = false;
            }

            return _cachedVertexCount.Value;
        }
    }
}
