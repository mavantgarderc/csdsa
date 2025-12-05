namespace Csdsa.DataStructures.Traversals;

/// <summary>
/// Provides traversal for <see cref="LinkedList{T}"/> collections.
/// </summary>
public static partial class SequentialTraversal
{
    /// <summary>
    /// Traverses an integer linked list in forward order and writes each element to the console.
    /// </summary>
    /// <param name="list">The linked list to traverse.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="list"/> is <see langword="null"/>.
    /// </exception>
    public static void TraverseLinkedList(LinkedList<int> list)
    {
        if (list == null)
        {
            throw new ArgumentNullException(nameof(list));
        }

        foreach (int item in list)
        {
            Console.WriteLine(item);
        }
    }
}
