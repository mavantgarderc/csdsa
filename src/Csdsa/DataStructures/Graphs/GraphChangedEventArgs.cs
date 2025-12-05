using System;

namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Provides data for the <see cref="Graph{T}.GraphChanged"/> event.
/// </summary>
/// <typeparam name="T">The vertex type.</typeparam>
public sealed class GraphChangedEventArgs<T> : EventArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GraphChangedEventArgs{T}"/> class.
    /// </summary>
    /// <param name="reason">The reason describing what changed in the graph.</param>
    public GraphChangedEventArgs(GraphChangeReason reason)
    {
        Reason = reason;
    }

    /// <summary>
    /// Gets the reason describing what changed in the graph.
    /// </summary>
    public GraphChangeReason Reason { get; }
}
