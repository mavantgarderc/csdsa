namespace Csdsa.DataStructures.Traversals;

/// <summary>
/// Provides traversal for <see cref="HashSet{T}"/> collections.
/// </summary>
public static partial class SequentialTraversal
{
    /// <summary>
    /// Traverses a set and writes each element to the console.
    /// </summary>
    /// <typeparam name="T">The element type.</typeparam>
    /// <param name="set">The set to traverse.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="set"/> is <see langword="null"/>.
    /// </exception>
    public static void TraverseSet<T>(HashSet<T> set)
    {
        if (set == null)
        {
            throw new ArgumentNullException(nameof(set));
        }

        foreach (T item in set)
        {
            Console.WriteLine(item);
        }
    }
}
