using Csdsa.DataStructures.Graphs;

namespace Csdsa.Algorithms.GraphTraversal;

public static partial class Dfs
{
    /// <summary>
    /// Determines whether the specified undirected graph contains a cycle
    /// using depth-first search.
    /// </summary>
    /// <param name="graph">The undirected graph to inspect.</param>
    /// <returns>
    /// <see langword="true"/> if the graph contains a cycle; otherwise, <see langword="false"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="graph"/> is <see langword="null"/>.
    /// </exception>
    public static bool HasCycleUndirected(Graph<int> graph)
    {
        ArgumentNullException.ThrowIfNull(graph);

        HashSet<int> visited = new HashSet<int>();

        bool DfsInternal(int u, int parent)
        {
            visited.Add(u);

            foreach (int v in graph.Adj[u])
            {
                if (!visited.Contains(v))
                {
                    if (DfsInternal(v, u))
                    {
                        return true;
                    }
                }
                else if (v != parent)
                {
                    return true;
                }
            }

            return false;
        }

        foreach (int node in graph.Adj.Keys)
        {
            if (!visited.Contains(node) && DfsInternal(node, -1))
            {
                return true;
            }
        }

        return false;
    }
}
