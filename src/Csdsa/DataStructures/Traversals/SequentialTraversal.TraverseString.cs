namespace Csdsa.DataStructures.Traversals;

/// <summary>
/// Provides traversal for strings.
/// </summary>
public static partial class SequentialTraversal
{
    /// <summary>
    /// Traverses a string character by character and writes each character to the console.
    /// </summary>
    /// <param name="s">The string to traverse.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="s"/> is <see langword="null"/>.
    /// </exception>
    public static void TraverseString(string s)
    {
        if (s == null)
        {
            throw new ArgumentNullException(nameof(s));
        }

        foreach (char c in s)
        {
            Console.WriteLine(c);
        }
    }
}
