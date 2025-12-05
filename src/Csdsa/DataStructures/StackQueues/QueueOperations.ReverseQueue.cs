namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides helper operations for working with queues.
/// </summary>
public static partial class QueueOperations
{
    /// <summary>
    /// Reverses the order of elements in the specified queue in place.
    /// </summary>
    /// <typeparam name="T">The type of elements stored in the queue.</typeparam>
    /// <param name="queue">The queue whose elements should be reversed.</param>
    /// <returns>The same instance of <paramref name="queue"/> after reversal.</returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="queue"/> is <see langword="null"/>.
    /// </exception>
    public static Queue<T> ReverseQueue<T>(Queue<T> queue)
    {
        if (queue == null)
        {
            throw new ArgumentNullException(nameof(queue));
        }

        Stack<T> stack = new Stack<T>();

        while (queue.Count > 0)
        {
            stack.Push(queue.Dequeue());
        }

        while (stack.Count > 0)
        {
            queue.Enqueue(stack.Pop());
        }

        return queue;
    }
}
