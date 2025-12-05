namespace Csdsa.DataStructures.Traversals;

/// <summary>
/// Provides traversal for <see cref="Dictionary{TKey, TValue}"/> collections.
/// </summary>
public static partial class SequentialTraversal
{
    /// <summary>
    /// Traverses a dictionary and writes each key/value pair to the console.
    /// </summary>
    /// <typeparam name="TKey">The key type.</typeparam>
    /// <typeparam name="TValue">The value type.</typeparam>
    /// <param name="dict">The dictionary to traverse.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="dict"/> is <see langword="null"/>.
    /// </exception>
    public static void TraverseDictionary<TKey, TValue>(Dictionary<TKey, TValue> dict)
        where TKey : notnull
    {
        if (dict == null)
        {
            throw new ArgumentNullException(nameof(dict));
        }

        foreach (KeyValuePair<TKey, TValue> kv in dict)
        {
            Console.WriteLine(kv.Key + ": " + kv.Value);
        }
    }
}
