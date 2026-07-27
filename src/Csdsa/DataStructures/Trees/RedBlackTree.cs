namespace Csdsa.DataStructures.Trees;

/// <summary>
/// Represents a generic self-balancing binary search tree (Red-Black tree) where each node has a color
/// (red or black) and the tree maintains specific properties to ensure balanced height.
/// <para>
/// Concepts:
/// </para>
/// <list type="bullet">
///   <item>
///     <description>
///     Red-Black tree properties: every node is either red or black, root is black, no two red nodes
///     can be adjacent, and all paths from a node to its descendant NULL nodes contain the same number of black nodes.
///     </description>
///   </item>
///   <item>
///     <description>
///     Self-balancing through rotations and color flips to maintain O(log n) height.
///     </description>
///   </item>
///   <item>
///     <description>
///     Supports efficient searching, insertion, and deletion with guaranteed O(log n) time complexity.
///     </description>
///   </item>
///   <item>
///     <description>
///     Provides multiple traversal algorithms: inorder, preorder, postorder, and level-order.
///     </description>
///   </item>
/// </list>
/// <para>
/// Key practices:
/// </para>
/// <list type="bullet">
///   <item>
///     <description>Encapsulation of tree structure behind methods and read-only views.</description>
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
/// <typeparam name="T">
/// The value type stored in the tree nodes. Values must be comparable and equatable
/// to support ordering and dictionary keys.
/// </typeparam>
public partial class RedBlackTree<T>
    where T : IComparable<T>, IEquatable<T>
{
    /// <summary>
    /// Represents the color of a node in the Red-Black tree.
    /// </summary>
    public enum NodeColor
    {
        /// <summary>
        /// Red node color.
        /// </summary>
        Red,

        /// <summary>
        /// Black node color.
        /// </summary>
        Black
    }

    /// <summary>
    /// Represents a node in the Red-Black tree.
    /// </summary>
    internal class Node
    {
        /// <summary>
        /// Gets or sets the value stored in the node.
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// Gets or sets the left child node.
        /// </summary>
        public Node Left { get; set; } = null!;

        /// <summary>
        /// Gets or sets the right child node.
        /// </summary>
        public Node Right { get; set; } = null!;

        /// <summary>
        /// Gets or sets the parent node.
        /// </summary>
        public Node Parent { get; set; } = null!;

        /// <summary>
        /// Gets or sets the color of the node.
        /// </summary>
        public NodeColor Color { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="value">The value to store in the node.</param>
        /// <param name="color">The color of the node.</param>
        public Node(T value, NodeColor color = NodeColor.Red)
        {
            Value = value;
            Color = color;
        }
    }

    /// <summary>
    /// Gets the root node of the tree.
    /// </summary>
    internal Node Root { get; private set; }

    /// <summary>
    /// Gets the number of nodes in the tree.
    /// </summary>
    public int Count { get; private set; }

    /// <summary>
    /// A sentinel node representing a null leaf (NIL node).
    /// </summary>
    private readonly Node _nilNode;

    /// <summary>
    /// Initializes a new instance of the <see cref="RedBlackTree{T}"/> class.
    /// </summary>
    public RedBlackTree()
    {
        // Create a sentinel NIL node that represents all null leaves
        _nilNode = new Node(default(T)!, NodeColor.Black);
        Root = _nilNode;
        Count = 0;
    }
}
