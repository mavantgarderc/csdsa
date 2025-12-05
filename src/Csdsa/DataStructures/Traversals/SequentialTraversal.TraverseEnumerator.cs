namespace Csdsa.DataStructures.Traversals;

/// <summary>
/// Provides traversal using an explicit enumerator.
/// </summary>
public static partial class SequentialTraversal
{
    /// <summary>
    /// Traverses a sequence using its enumerator and writes each element to the console.
    /// Demonstrates explicit enumerator usage.
    /// </summary>
    /// <typeparam name="T">The element type.</typeparam>
    /// <param name="collection">The sequence to traverse.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="collection"/> is <see langword="null"/>.
    /// </exception>
    public static void TraverseEnumerator<T>(IEnumerable<T> collection)
    {
        if (collection == null)
        {
            throw new ArgumentNullException(nameof(collection));
        }

        using IEnumerator<T> enumerator = collection.GetEnumerator();

        while (enumerator.MoveNext())
        {
            Console.WriteLine(enumerator.Current);
        }
    }
}
