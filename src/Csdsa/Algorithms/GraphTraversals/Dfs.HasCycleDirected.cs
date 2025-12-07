using Csdsa.DataStructures.Graphs;

namespace Csdsa.Algorithms.GraphTraversal;

public static partial class Dfs
{
    /// <summary>
    /// Determines whether the specified directed graph contains a cycle
    /// using depth-first search with a recursion stack.
    /// </summary>
    /// <param name="graph">The directed graph to inspect.</param>
    /// <returns>
    /// <see langword="true"/> if the graph contains a directed cycle;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="graph"/> is <see langword="null"/>.
    /// </exception>
    public static bool HasCycleDirected(Graph<int> graph)
    {
        ArgumentNullException.ThrowIfNull(graph);

        HashSet<int> visited = new HashSet<int>();
        HashSet<int> stack = new HashSet<int>();

        bool DfsInternal(int u)
        {
            if (stack.Contains(u))
            {
                return true;
            }

            if (!visited.Add(u))
            {
                return false;
            }

            stack.Add(u);

            foreach (int v in graph.Adj[u])
            {
                if (DfsInternal(v))
                {
                    return true;
                }
            }

            stack.Remove(u);
            return false;
        }

        foreach (int node in graph.Adj.Keys)
        {
            if (DfsInternal(node))
            {
                return true;
            }
        }

        return false;
    }
}
