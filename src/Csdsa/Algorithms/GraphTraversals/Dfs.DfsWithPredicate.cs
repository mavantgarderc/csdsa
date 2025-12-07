using Csdsa.DataStructures.Graphs;

namespace Csdsa.Algorithms.GraphTraversal;

public static partial class Dfs
{
    /// <summary>
    /// Performs DFS from the specified source vertex and returns the depth
    /// at which a vertex satisfying the given predicate is first encountered.
    /// </summary>
    /// <param name="graph">The graph to traverse.</param>
    /// <param name="source">The starting vertex.</param>
    /// <param name="predicate">The predicate to test against visited vertices.</param>
    /// <returns>
    /// The depth of the first vertex satisfying the predicate,
    /// or -1 if no such vertex is reachable.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="graph"/> or <paramref name="predicate"/>
    /// is <see langword="null"/>.
    /// </exception>
    public static int DFSWithPredicate(
        Graph<int> graph,
        int source,
        Func<int, bool> predicate)
    {
        ArgumentNullException.ThrowIfNull(graph);
        ArgumentNullException.ThrowIfNull(predicate);

        HashSet<int> visited = new HashSet<int>();
        Stack<(int Vertex, int Depth)> stack = new Stack<(int, int)>();

        stack.Push((source, 0));

        while (stack.Count > 0)
        {
            (int u, int depth) = stack.Pop();

            if (!visited.Add(u))
            {
                continue;
            }

            if (predicate(u))
            {
                return depth;
            }

            foreach (int v in graph.Adj[u])
            {
                if (!visited.Contains(v))
                {
                    stack.Push((v, depth + 1));
                }
            }
        }

        return -1;
    }
}
