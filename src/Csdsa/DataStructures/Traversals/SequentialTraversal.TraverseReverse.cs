namespace Csdsa.DataStructures.Traversals;

/// <summary>
/// Provides reverse-order traversal for indexed lists.
/// </summary>
public static partial class SequentialTraversal
{
    /// <summary>
    /// Traverses a list in reverse order and writes each element to the console.
    /// </summary>
    /// <typeparam name="T">The element type.</typeparam>
    /// <param name="list">The list to traverse.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="list"/> is <see langword="null"/>.
    /// </exception>
    public static void TraverseReverse<T>(IList<T> list)
    {
        TravereReverse(list);
    }

    /// <summary>
    /// Backward-compatible misspelled reverse traversal method.
    /// </summary>
    /// <typeparam name="T">The element type.</typeparam>
    /// <param name="list">The list to traverse.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="list"/> is <see langword="null"/>.
    /// </exception>
    public static void TravereReverse<T>(IList<T> list)
    {
        if (list == null)
        {
            throw new ArgumentNullException(nameof(list));
        }

        for (int i = list.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(list[i]);
        }
    }
}
