namespace Csdsa.DataStructures.Traversals;

/// <summary>
/// Provides traversal for <see cref="Span{T}"/> of <see cref="int"/>.
/// </summary>
public static partial class SequentialTraversal
{
    /// <summary>
    /// Traverses an integer span by index and writes each element to the console.
    /// </summary>
    /// <param name="span">The span to traverse.</param>
    public static void TraverseSpan(Span<int> span)
    {
        for (int i = 0; i < span.Length; i++)
        {
            Console.WriteLine(span[i]);
        }
    }
}
