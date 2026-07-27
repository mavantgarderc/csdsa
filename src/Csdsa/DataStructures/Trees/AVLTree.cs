namespace Csdsa.DataStructures.Trees;

/// <summary>
/// Represents a generic self-balancing binary search tree (AVL tree) where the heights
/// of the two child subtrees of any node differ by at most one.
/// <para>
/// Concepts:
/// </para>
/// <list type="bullet">
///   <item>
///     <description>
///     AVL tree property: balance factor (height difference) of any node is -1, 0, or 1.
///     </description>
///   </item>
///   <item>
///     <description>
///     Self-balancing through rotations to maintain O(log n) height.
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
public partial class AVLTree<T>
    where T : IComparable<T>, IEquatable<T>
{
    /// <summary>
    /// Represents a node in the AVL tree.
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
        public Node Left { get; set; }

        /// <summary>
        /// Gets or sets the right child node.
        /// </summary>
        public Node Right { get; set; }

        /// <summary>
        /// Gets or sets the height of the node.
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="value">The value to store in the node.</param>
        public Node(T value)
        {
            Value = value;
            Height = 1; // Height starts at 1 for a single node
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
    /// Initializes a new instance of the <see cref="AVLTree{T}"/> class.
    /// </summary>
    public AVLTree()
    {
        Root = null;
        Count = 0;
    }
}
