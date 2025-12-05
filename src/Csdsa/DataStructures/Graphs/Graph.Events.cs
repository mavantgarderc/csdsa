namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Provides change notification events for <see cref="Graph{T}"/>.
/// </summary>
public partial class Graph<T>
    where T : IComparable<T>, IEquatable<T>
{
    /// <summary>
    /// Occurs when the graph structure changes (vertices or edges updated).
    /// </summary>
    public event EventHandler<GraphChangedEventArgs<T>> GraphChanged;

    /// <summary>
    /// Raises the <see cref="GraphChanged"/> event.
    /// </summary>
    /// <param name="reason">The reason describing what changed in the graph.</param>
    protected virtual void OnGraphChanged(GraphChangeReason reason)
    {
        EventHandler<GraphChangedEventArgs<T>> handler = GraphChanged;
        if (handler != null)
        {
            handler(this, new GraphChangedEventArgs<T>(reason));
        }
    }
}
