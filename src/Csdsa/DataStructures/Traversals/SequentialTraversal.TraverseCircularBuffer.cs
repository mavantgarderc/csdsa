namespace Csdsa.DataStructures.Traversals;

/// <summary>
/// Provides traversal for a circular buffer stored in an array.
/// </summary>
public static partial class SequentialTraversal
{
    /// <summary>
    /// Traverses a circular buffer and writes each logical element to the console.
    /// </summary>
    /// <typeparam name="T">The element type.</typeparam>
    /// <param name="buffer">The underlying array storing the circular buffer.</param>
    /// <param name="head">
    /// The index of the logical head element in the circular buffer.
    /// </param>
    /// <param name="size">The number of elements currently stored in the buffer.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="buffer"/> is <see langword="null"/>.
    /// </exception>
    public static void TraverseCircularBuffer<T>(T[] buffer, int head, int size)
    {
        if (buffer == null)
        {
            throw new ArgumentNullException(nameof(buffer));
        }

        int capacity = buffer.Length;

        for (int i = 0; i < size; i++)
        {
            int index = (head + 1 + i) % capacity;
            Console.WriteLine(buffer[index]);
        }
    }
}
