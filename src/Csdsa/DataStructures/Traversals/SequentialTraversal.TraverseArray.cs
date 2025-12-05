namespace Csdsa.DataStructures.Traversals;

/// <summary>
/// Provides traversal for one-dimensional arrays.
/// </summary>
public static partial class SequentialTraversal
{
    /// <summary>
    /// Traverses an integer array from index 0 to the last element and writes each value
    /// to the console.
    /// </summary>
    /// <param name="array">The array to traverse.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="array"/> is <see langword="null"/>.
    /// </exception>
    public static void TraverseArray(int[] array)
    {
        if (array == null)
        {
            throw new ArgumentNullException(nameof(array));
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}
