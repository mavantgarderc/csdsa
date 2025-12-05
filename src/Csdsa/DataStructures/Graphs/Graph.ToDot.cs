using System.Text;

namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Provides the <see cref="ToDot"/> method for <see cref="Graph{T}"/>.
/// </summary>
public partial class Graph<T>
    where T : System.IComparable<T>, System.IEquatable<T>
{
    /// <summary>
    /// Creates a Graphviz DOT representation of the graph.
    /// </summary>
    /// <returns>A string containing the DOT source for the graph.</returns>
    public string ToDot()
    {
        StringBuilder sb = new StringBuilder(IsDirected ? "digraph G {\n" : "graph G {\n");

        foreach (KeyValuePair<T, List<(T Vertex, int Weight)>> kvp in _adj)
        {
            foreach ((T dst, int weight) in kvp.Value)
            {
                string connector = IsDirected ? "->" : "--";
                sb.AppendLine(
                    "    " + kvp.Key + " " + connector + " " + dst + " [label=\"" + weight + "\"];");
            }
        }

        sb.AppendLine("}");
        return sb.ToString();
    }
}
