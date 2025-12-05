namespace Csdsa.DataStructures.Traversals;

/// <summary>
/// Provides traversal for <see cref="Stack{T}"/> collections.
/// </summary>
public static partial class SequentialTraversal
{
    /// <summary>
    /// Traverses the elements of the specified stack from top to bottom and writes them
    /// to the console.
    /// </summary>
    /// <typeparam name="T">The type of elements in the stack.</typeparam>
    /// <param name="stack">The stack to traverse.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="stack"/> is <see langword="null"/>.
    /// </exception>
    public static void TraverseStack<T>(Stack<T> stack)
    {
        if (stack == null)
        {
            throw new ArgumentNullException(nameof(stack));
        }

        foreach (T item in stack)
        {
            Console.WriteLine(item);
        }
    }
}
