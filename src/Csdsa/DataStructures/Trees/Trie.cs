namespace Csdsa.DataStructures.Trees;

/// <summary>
/// Represents a generic trie (prefix tree) data structure for efficient storage and retrieval of strings.
/// <para>
/// Concepts:
/// </para>
/// <list type="bullet">
///   <item>
///     <description>
///     Trie structure with nodes representing characters and paths representing strings.
///     </description>
///   </item>
///   <item>
///     <description>
///     Supports efficient prefix-based operations and autocomplete functionality.
///     </description>
///   </item>
///   <item>
///     <description>
///     Provides fast insertion, search, and prefix matching with O(m) time complexity where m is the length of the string.
///     </description>
///   </item>
///   <item>
///     <description>
///     Memory-efficient for storing strings with common prefixes.
///     </description>
///   </item>
/// </list>
/// <para>
/// Key practices:
/// </para>
/// <list type="bullet">
///   <item>
///     <description>Encapsulation of trie structure behind methods and read-only views.</description>
///   </item>
///   <item>
///     <description>Self-contained methods for individual operations.</description>
///   </item>
///   <item>
///     <description>
///     Clear exception behavior for error conditions.
///     </description>
///   </item>
///   <item>
///     <description>
///     Forward-looking design that can be extended with advanced algorithms
///     or specialized operations.
///     </description>
///   </item>
///   <item>
///     <description>Generic support and serialization helpers.</description>
///   </item>
/// </list>
/// </summary>
public partial class Trie
{
    /// <summary>
    /// Represents a node in the trie.
    /// </summary>
    internal class Node
    {
        /// <summary>
        /// Gets the dictionary of child nodes, keyed by character.
        /// </summary>
        public Dictionary<char, Node> Children { get; }

        /// <summary>
        /// Gets or sets a value indicating whether this node represents the end of a word.
        /// </summary>
        public bool IsEndOfWord { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        public Node()
        {
            Children = new Dictionary<char, Node>();
            IsEndOfWord = false;
        }
    }

    /// <summary>
    /// Gets the root node of the trie.
    /// </summary>
    internal Node Root { get; }

    /// <summary>
    /// Gets the number of words in the trie.
    /// </summary>
    public int Count { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Trie"/> class.
    /// </summary>
    public Trie()
    {
        Root = new Node();
        Count = 0;
    }
}
