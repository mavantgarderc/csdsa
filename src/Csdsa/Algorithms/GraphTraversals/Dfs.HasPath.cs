using Csdsa.DataStructures.Graphs;

namespace Csdsa.Algorithms.GraphTraversal;

public static partial class Dfs
{
    /// <summary>
    /// Determines whether there exists a path from the specified source vertex
    /// to the specified destination vertex using DFS.
    /// </summary>
    /// <param name="graph">The graph to search.</param>
    /// <param name="source">The source vertex.</param>
    /// <param name="destination">The destination vertex.</param>
    /// <returns>
    /// <see langword="true"/> if a path exists from <paramref name="source"/>
    /// to <paramref name="destination"/>; otherwise, <see langword="false"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="graph"/> is <see langword="null"/>.
    /// </exception>
    public static bool HasPath(Graph<int> graph, int source, int destination)
    {
        ArgumentNullException.ThrowIfNull(graph);

        HashSet<int> visited = new HashSet<int>();
        Stack<int> stack = new Stack<int>();

        stack.Push(source);

        while (stack.Count > 0)
        {
            int u = stack.Pop();

            if (u == destination)
            {
                return true;
            }

            if (!visited.Add(u))
            {
                continue;
            }

            foreach (int v in graph.Adj[u])
            {
                if (!visited.Contains(v))
                {
                    stack.Push(v);
                }
            }
        }

        return false;
    }
}
