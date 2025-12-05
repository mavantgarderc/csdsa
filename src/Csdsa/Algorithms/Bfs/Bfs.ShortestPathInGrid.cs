namespace Csdsa.Algorithms.GraphTraversal;

public static partial class Bfs
{
    /// <summary>
    /// Computes the length of the shortest path between two points
    /// in a grid of obstacles, using four-directional BFS.
    /// </summary>
    /// <param name="grid">
    /// The grid, where 0 represents a free cell and non-zero represents an obstacle.
    /// </param>
    /// <param name="start">The starting cell.</param>
    /// <param name="end">The target cell.</param>
    /// <returns>
    /// The length of the shortest path, or -1 if the target is unreachable.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="grid"/> is <see langword="null"/>.
    /// </exception>
    public static int ShortestPathInGrid(int[,] grid, Point start, Point end)
    {
        ArgumentNullException.ThrowIfNull(grid);

        int rows = grid.GetLength(0);
        int cols = grid.GetLength(1);

        int[] dx = { 0, 1, 0, -1 };
        int[] dy = { 1, 0, -1, 0 };

        int[,] distances = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                distances[i, j] = -1;
            }
        }

        Queue<Point> queue = new Queue<Point>();

        queue.Enqueue(start);
        distances[start.X, start.Y] = 0;

        while (queue.Count > 0)
        {
            Point p = queue.Dequeue();

            if (p.X == end.X && p.Y == end.Y)
            {
                return distances[p.X, p.Y];
            }

            for (int k = 0; k < 4; k++)
            {
                int nx = p.X + dx[k];
                int ny = p.Y + dy[k];

                if (nx >= 0
                    && nx < rows
                    && ny >= 0
                    && ny < cols
                    && grid[nx, ny] == 0
                    && distances[nx, ny] == -1)
                {
                    distances[nx, ny] = distances[p.X, p.Y] + 1;
                    queue.Enqueue(new Point(nx, ny));
                }
            }
        }

        return -1;
    }
}
