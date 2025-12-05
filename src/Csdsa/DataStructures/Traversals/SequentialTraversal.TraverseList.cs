namespace Csdsa.DataStructures.Traversals;

/// <summary>
/// Provides traversal for list-like collections of <see cref="int"/>.
/// </summary>
public static partial class SequentialTraversal
{
    /// <summary>
    /// Traverses an integer list in forward order and writes each element to the console.
    /// </summary>
    /// <param name="list">The list-like collection to traverse.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="list"/> is <see langword="null"/>.
    /// </exception>
    public static void TraverseList(IReadOnlyList<int> list)
    {
        if (list == null)
        {
            throw new ArgumentNullException(nameof(list));
        }

        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
    }
}
