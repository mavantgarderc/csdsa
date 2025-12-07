using Csdsa.DataStructures.Graphs;

namespace Csdsa.Algorithms.GraphTraversal;

public static partial class Dfs
{
    /// <summary>
    /// Performs a topological sort of a directed graph using DFS postorder.
    /// </summary>
    /// <param name="graph">The directed graph to sort.</param>
    /// <returns>
    /// A read-only list representing a topological ordering of the vertices.
    /// The result is not guaranteed to be valid if the graph contains cycles.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="graph"/> is <see langword="null"/>.
    /// </exception>
    public static IReadOnlyList<int> TopologicalSortDFS(Graph<int> graph)
    {
        ArgumentNullException.ThrowIfNull(graph);

        HashSet<int> visited = new HashSet<int>();
        List<int> result = new List<int>();

        void DfsInternal(int u)
        {
            visited.Add(u);

            foreach (int v in graph.Adj[u])
            {
                if (!visited.Contains(v))
                {
                    DfsInternal(v);
                }
            }

            result.Add(u);
        }

        foreach (int u in graph.Adj.Keys)
        {
            if (!visited.Contains(u))
            {
                DfsInternal(u);
            }
        }

        result.Reverse();
        return result;
    }
}
