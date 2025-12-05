namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Specifies the reason for a graph change notification.
/// </summary>
public enum GraphChangeReason
{
    /// <summary>One or more vertices were added.</summary>
    VertexAdded,

    /// <summary>One or more vertices were removed.</summary>
    VertexRemoved,

    /// <summary>One or more edges were added.</summary>
    EdgeAdded,

    /// <summary>One or more edges were removed.</summary>
    EdgeRemoved,

    /// <summary>A structural change that does not fit any other category.</summary>
    Other,
}
