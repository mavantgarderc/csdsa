namespace Csdsa.DataStructures.Graphs;

/// <summary>
/// Provides graph coloring for <see cref="Graph{T}"/>.
/// </summary>
public partial class Graph<T>
    where T : System.IComparable<T>, System.IEquatable<T>
{
    /// <summary>
    /// Attempts to color the graph using at most the specified number of colors.
    /// </summary>
    /// <param name="maxColors">The maximum number of colors allowed.</param>
    /// <returns>
    /// A dictionary mapping each vertex to its assigned color index.
    /// </returns>
    /// <exception cref="InvalidOperationException">
    /// Thrown when the graph cannot be colored with the specified number of colors.
    /// </exception>
    public Dictionary<T, int> GraphColoring(int maxColors)
    {
        List<T> nodes = _adj.Keys.ToList();
        Dictionary<T, int> colors = new Dictionary<T, int>();

        foreach (T node in nodes)
        {
            colors[node] = -1;
        }

        foreach (T node in nodes)
        {
            HashSet<int> unavailable = new HashSet<int>();
            HashSet<T> allNeighbors = new HashSet<T>();

            foreach (T neighbor in GetNeighbors(node))
            {
                allNeighbors.Add(neighbor);
            }

            foreach (KeyValuePair<T, List<(T Vertex, int Weight)>> kvp in _adj)
            {
                if (kvp.Value.Any(e => e.Vertex.Equals(node)))
                {
                    allNeighbors.Add(kvp.Key);
                }
            }

            foreach (T neighbor in allNeighbors)
            {
                if (colors.TryGetValue(neighbor, out int colorIndex) && colorIndex != -1)
                {
                    unavailable.Add(colorIndex);
                }
            }

            int color = 0;
            while (unavailable.Contains(color))
            {
                color++;
            }

            if (color >= maxColors)
            {
                throw new InvalidOperationException("The graph cannot be colored with the specified number of colors.");
            }

            colors[node] = color;
        }

        return colors;
    }
}
