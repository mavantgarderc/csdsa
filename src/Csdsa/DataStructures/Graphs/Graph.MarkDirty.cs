namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Provides internal change tracking for <see cref="Graph{T}"/>.
/// </summary>
public partial class Graph<T>
    where T : System.IComparable<T>, System.IEquatable<T>
{
    /// <summary>
    /// Marks the graph as structurally modified, invalidating cached information
    /// such as the vertex count and raising the <see cref="GraphChanged"/> event.
    /// </summary>
    private void MarkDirty()
    {
        _isDirty = true;
        OnGraphChanged(GraphChangeReason.Other);
    }
}
