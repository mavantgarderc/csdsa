namespace Csdsa.DataStructures.Trees;

public partial class Trie
{
    /// <summary>
    /// Inserts a word into the trie.
    /// </summary>
    /// <param name="word">The word to insert into the trie.</param>
    public void Insert(string word)
    {
        ArgumentNullException.ThrowIfNull(word);

        Node current = Root;

        foreach (char c in word)
        {
            if (!current.Children.TryGetValue(c, out Node childNode))
            {
                childNode = new Node();
                current.Children[c] = childNode;
            }

            current = childNode;
        }

        // Mark the end of the word only if it's not already marked
        if (!current.IsEndOfWord)
        {
            current.IsEndOfWord = true;
            Count++;
        }
    }

    /// <summary>
    /// Inserts multiple words into the trie.
    /// </summary>
    /// <param name="words">The collection of words to insert into the trie.</param>
    public void InsertRange(IEnumerable<string> words)
    {
        ArgumentNullException.ThrowIfNull(words);

        foreach (string word in words)
        {
            Insert(word);
        }
    }
}
