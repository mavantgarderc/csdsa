namespace Csdsa.DataStructures.Trees;

public partial class Trie
{
    /// <summary>
    /// Returns all words in the trie that start with the given prefix.
    /// </summary>
    /// <param name="prefix">The prefix to search for.</param>
    /// <returns>An enumerable collection of words that start with the given prefix.</returns>
    public IEnumerable<string> GetWordsWithPrefix(string prefix)
    {
        ArgumentNullException.ThrowIfNull(prefix);

        List<string> result = new List<string>();

        Node node = FindNode(prefix);
        if (node != null)
        {
            // If the prefix itself is a word, add it
            if (node.IsEndOfWord)
            {
                result.Add(prefix);
            }

            // Find all words that extend from this node
            GetWordsFromNode(node, prefix, result);
        }

        return result;
    }

    /// <summary>
    /// Helper method to recursively find all words from a given node.
    /// </summary>
    /// <param name="node">The node to start from.</param>
    /// <param name="currentWord">The current word being built.</param>
    /// <param name="result">The list to add found words to.</param>
    private static void GetWordsFromNode(Node node, string currentWord, List<string> result)
    {
        foreach (var kvp in node.Children)
        {
            string newWord = currentWord + kvp.Key;

            if (kvp.Value.IsEndOfWord)
            {
                result.Add(newWord);
            }

            GetWordsFromNode(kvp.Value, newWord, result);
        }
    }

    /// <summary>
    /// Checks if the trie contains any word.
    /// </summary>
    /// <returns><see langword="true"/> if the trie contains at least one word; otherwise, <see langword="false"/>.</returns>
    public bool Any()
    {
        return Count > 0;
    }

    /// <summary>
    /// Removes a word from the trie if it exists.
    /// </summary>
    /// <param name="word">The word to remove from the trie.</param>
    /// <returns><see langword="true"/> if the word was found and removed; otherwise, <see langword="false"/>.</returns>
    public bool Remove(string word)
    {
        ArgumentNullException.ThrowIfNull(word);

        bool wordExisted = RemoveRecursive(Root, word, 0);
        if (wordExisted)
        {
            Count--;
        }

        return wordExisted;
    }

    /// <summary>
    /// Helper method to recursively remove a word from the trie.
    /// </summary>
    /// <param name="node">The current node in the traversal.</param>
    /// <param name="word">The word to remove.</param>
    /// <param name="index">The current index in the word.</param>
    /// <returns><see langword="true"/> if the word was found and removed; otherwise, <see langword="false"/>.</returns>
    private static bool RemoveRecursive(Node node, string word, int index)
    {
        if (index == word.Length)
        {
            // We've reached the end of the word
            if (!node.IsEndOfWord)
            {
                // Word doesn't exist in the trie
                return false;
            }

            node.IsEndOfWord = false;

            // Return true if this node has no children (can be deleted)
            return node.Children.Count == 0;
        }

        char c = word[index];
        if (!node.Children.TryGetValue(c, out Node childNode))
        {
            // Word doesn't exist in the trie
            return false;
        }

        bool shouldDeleteChild = RemoveRecursive(childNode, word, index + 1);

        if (shouldDeleteChild)
        {
            node.Children.Remove(c);

            // Return true if this node is not the end of another word and has no other children
            return !node.IsEndOfWord && node.Children.Count == 0;
        }

        return false;
    }
}
