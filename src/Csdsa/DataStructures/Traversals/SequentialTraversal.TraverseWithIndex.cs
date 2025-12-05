namespace Csdsa.DataStructures.Traversals;

/// <summary>
/// Provides indexed traversal for <see cref="IEnumerable{T}"/> sequences.
/// </summary>
public static partial class SequentialTraversal
{
    /// <summary>
    /// Traverses a sequence and writes each element to the console prefixed with its index.
    /// </summary>
    /// <typeparam name="T">The element type.</typeparam>
    /// <param name="collection">The sequence to traverse.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="collection"/> is <see langword="null"/>.
    /// </exception>
    public static void TraverseWithIndex<T>(IEnumerable<T> collection)
    {
        if (collection == null)
        {
            throw new ArgumentNullException(nameof(collection));
        }

        int index = 0;

        foreach (T item in collection)
        {
            Console.WriteLine("[" + index + "] = " + item);
            index++;
        }
    }
}
