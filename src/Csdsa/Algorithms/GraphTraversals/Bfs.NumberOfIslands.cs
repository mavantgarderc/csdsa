namespace Csdsa.Algorithms.GraphTraversal;

public static partial class Bfs
{
    /// <summary>
    /// Counts the number of connected components of 1s in a binary grid
    /// using BFS, considering four-directional connectivity.
    /// </summary>
    /// <param name="grid">The grid in which to count islands.</param>
    /// <returns>The number of islands found in the grid.</returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="grid"/> is <see langword="null"/>.
    /// </exception>
    public static int NumberOfIslands(int[,] grid)
    {
        ArgumentNullException.ThrowIfNull(grid);

        int rows = grid.GetLength(0);
        int cols = grid.GetLength(1);

        int islands = 0;
        bool[,] visited = new bool[rows, cols];
        int[] dx = { 0, 1, 0, -1 };
        int[] dy = { 1, 0, -1, 0 };

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (grid[i, j] == 1 && !visited[i, j])
                {
                    islands++;
                    Queue<Point> queue = new Queue<Point>();
                    queue.Enqueue(new Point(i, j));
                    visited[i, j] = true;

                    while (queue.Count > 0)
                    {
                        Point p = queue.Dequeue();

                        for (int k = 0; k < 4; k++)
                        {
                            int nx = p.X + dx[k];
                            int ny = p.Y + dy[k];

                            if (nx >= 0
                                && nx < rows
                                && ny >= 0
                                && ny < cols
                                && grid[nx, ny] == 1
                                && !visited[nx, ny])
                            {
                                visited[nx, ny] = true;
                                queue.Enqueue(new Point(nx, ny));
                            }
                        }
                    }
                }
            }
        }

        return islands;
    }
}
