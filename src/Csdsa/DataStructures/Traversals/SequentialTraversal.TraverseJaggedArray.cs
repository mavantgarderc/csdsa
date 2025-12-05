namespace Csdsa.DataStructures.Traversals;

/// <summary>
/// Provides traversal for jagged arrays.
/// </summary>
public static partial class SequentialTraversal
{
    /// <summary>
    /// Traverses a jagged integer array row by row and writes each element to the console.
    /// </summary>
    /// <param name="jagged">The jagged array to traverse.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="jagged"/> is <see langword="null"/>.
    /// </exception>
    public static void TraverseJaggedArray(int[][] jagged)
    {
        if (jagged == null)
        {
            throw new ArgumentNullException(nameof(jagged));
        }

        foreach (int[] row in jagged)
        {
            if (row == null)
            {
                continue;
            }

            foreach (int item in row)
            {
                Console.WriteLine(item);
            }
        }
    }
}
