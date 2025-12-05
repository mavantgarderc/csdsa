namespace Csdsa.Algorithms.GraphTraversal;

public static partial class Bfs
{
    /// <summary>
    /// Computes the minimum number of knight moves required to move from
    /// <paramref name="start"/> to <paramref name="end"/> on an N-by-N chessboard.
    /// </summary>
    /// <param name="size">The size of the board (N).</param>
    /// <param name="start">The starting square.</param>
    /// <param name="end">The target square.</param>
    /// <returns>
    /// The minimum number of moves, or -1 if the target is unreachable.
    /// </returns>
    public static int KnightsPath(int size, Point start, Point end)
    {
        int[] dx = { 2, 2, -2, -2, 1, 1, -1, -1 };
        int[] dy = { 1, -1, 1, -1, 2, -2, 2, -2 };

        bool[,] visited = new bool[size, size];
        Queue<(Point Position, int Depth)> queue = new Queue<(Point, int)>();

        queue.Enqueue((start, 0));
        visited[start.X, start.Y] = true;

        while (queue.Count > 0)
        {
            (Point position, int depth) = queue.Dequeue();

            if (position.X == end.X && position.Y == end.Y)
            {
                return depth;
            }

            for (int i = 0; i < 8; i++)
            {
                int nx = position.X + dx[i];
                int ny = position.Y + dy[i];

                if (nx >= 0 && nx < size && ny >= 0 && ny < size && !visited[nx, ny])
                {
                    visited[nx, ny] = true;
                    queue.Enqueue((new Point(nx, ny), depth + 1));
                }
            }
        }

        return -1;
    }
}
