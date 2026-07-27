namespace Csdsa.DataStructures.Trees;

/// <summary>
/// Represents a generic binary tree data structure with nodes that have at most two children.
/// <para>
/// Concepts:
/// </para>
/// <list type="bullet">
///   <item>
///     <description>
///     Binary tree structure with left and right child nodes.
///     </description>
///   </item>
///   <item>
///     <description>
///     Supports multiple traversal algorithms: inorder, preorder, postorder, and level-order.
///     </description>
///   </item>
///   <item>
///     <description>
///     Provides basic operations: insertion, search, and removal.
///     </description>
///   </item>
///   <item>
///     <description>
///     Can be used as a base for more specialized tree implementations like BST.
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
///     such as balancing or specialized traversals.
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
public partial class BinaryTree<T>
    where T : IComparable<T>, IEquatable<T>
{
    /// <summary>
    /// Represents a node in the binary tree.
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
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="value">The value to store in the node.</param>
        public Node(T value)
        {
            Value = value;
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
    /// Initializes a new instance of the <see cref="BinaryTree{T}"/> class.
    /// </summary>
    public BinaryTree()
    {
        Root = null;
        Count = 0;
    }
}
