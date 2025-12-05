namespace Csdsa.DataStructures.Traversals;

/// <summary>
/// Provides traversal for <see cref="Queue{T}"/> collections.
/// </summary>
public static partial class SequentialTraversal
{
    /// <summary>
    /// Traverses a queue in FIFO order and writes each element to the console.
    /// </summary>
    /// <typeparam name="T">The element type.</typeparam>
    /// <param name="queue">The queue to traverse.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="queue"/> is <see langword="null"/>.
    /// </exception>
    public static void TraverseQueue<T>(Queue<T> queue)
    {
        if (queue == null)
        {
            throw new ArgumentNullException(nameof(queue));
        }

        foreach (T item in queue)
        {
            Console.WriteLine(item);
        }
    }
}
