namespace Csdsa.Algorithms.GraphTraversal;

public static partial class GridDfs
{
    /// <summary>
    /// Counts the number of islands (4-directionally connected components of 1s)
    /// in a binary grid using DFS.
    /// </summary>
    /// <param name="grid">The binary grid to inspect.</param>
    /// <returns>The number of islands present in the grid.</returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="grid"/> is <see langword="null"/>.
    /// </exception>
    public static int NumberOfIslandsDFS(int[,] grid)
    {
        ArgumentNullException.ThrowIfNull(grid);

        int rows = grid.GetLength(0);
        int cols = grid.GetLength(1);

        bool[,] visited = new bool[rows, cols];
        int count = 0;

        void DfsInternal(int x, int y)
        {
            if (x < 0 || y < 0 || x >= rows || y >= cols)
            {
                return;
            }

            if (grid[x, y] != 1 || visited[x, y])
            {
                return;
            }

            visited[x, y] = true;

            DfsInternal(x + 1, y);
            DfsInternal(x - 1, y);
            DfsInternal(x, y + 1);
            DfsInternal(x, y - 1);
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (grid[i, j] == 1 && !visited[i, j])
                {
                    count++;
                    DfsInternal(i, j);
                }
            }
        }

        return count;
    }
}
