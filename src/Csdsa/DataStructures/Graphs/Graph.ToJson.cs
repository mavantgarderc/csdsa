using System.Text.Json;

namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Provides the <see cref="ToJson"/> method for <see cref="Graph{T}"/>.
/// </summary>
public partial class Graph<T>
    where T : System.IComparable<T>, System.IEquatable<T>
{
    private static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions
    {
        WriteIndented = true,
    };

    /// <summary>
    /// Serializes the graph to a JSON representation.
    /// </summary>
    /// <returns>A JSON string that describes the graph.</returns>
    public string ToJson()
    {
        object graphData = new
        {
            IsDirected,
            Vertices = _adj.Keys.ToList(),
            Edges = Edges.ToList(),
        };

        return JsonSerializer.Serialize(graphData, JsonOptions);
    }
}
