namespace Csdsa.DataStructures.Trees;

public partial class Trie
{
    /// <summary>
    /// Searches for a word in the trie.
    /// </summary>
    /// <param name="word">The word to search for in the trie.</param>
    /// <returns><see langword="true"/> if the word exists in the trie; otherwise, <see langword="false"/>.</returns>
    public bool Search(string word)
    {
        ArgumentNullException.ThrowIfNull(word);

        Node node = FindNode(word);
        return node != null && node.IsEndOfWord;
    }

    /// <summary>
    /// Finds the node corresponding to the end of the given word in the trie.
    /// </summary>
    /// <param name="word">The word to find the end node for.</param>
    /// <returns>The node at the end of the word, or <see langword="null"/> if the word doesn't exist.</returns>
    private Node FindNode(string word)
    {
        Node current = Root;

        foreach (char c in word)
        {
            if (!current.Children.TryGetValue(c, out Node childNode))
            {
                return null;
            }

            current = childNode;
        }

        return current;
    }

    /// <summary>
    /// Checks if there is any word in the trie that starts with the given prefix.
    /// </summary>
    /// <param name="prefix">The prefix to check for.</param>
    /// <returns><see langword="true"/> if there is a word with the given prefix; otherwise, <see langword="false"/>.</returns>
    public bool ContainsPrefix(string prefix)
    {
        ArgumentNullException.ThrowIfNull(prefix);

        Node node = FindNode(prefix);
        return node != null;
    }
}
