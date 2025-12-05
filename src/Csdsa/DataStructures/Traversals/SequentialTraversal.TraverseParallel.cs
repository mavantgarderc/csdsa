namespace Csdsa.DataStructures.Traversals;

/// <summary>
/// Provides parallel traversal for sequences.
/// </summary>
public static partial class SequentialTraversal
{
    /// <summary>
    /// Traverses a sequence in parallel and writes each element to the console.
    /// </summary>
    /// <typeparam name="T">The element type.</typeparam>
    /// <param name="collection">The sequence to traverse in parallel.</param>
    public static void TraverseParallel<T>(IEnumerable<T> collection)
    {
        Parallel.ForEach(
            collection,
            item =>
            {
                Console.WriteLine(item);
            });
    }
}
