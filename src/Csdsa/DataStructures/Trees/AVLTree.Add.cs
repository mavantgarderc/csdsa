namespace Csdsa.DataStructures.Trees;

public partial class AVLTree<T>
    where T : IComparable<T>, IEquatable<T>
{
    /// <summary>
    /// Gets the height of the given node.
    /// </summary>
    /// <param name="node">The node to get the height of.</param>
    /// <returns>The height of the node, or 0 if the node is null.</returns>
    private static int GetHeight(Node node)
    {
        if (node == null)
        {
            return 0;
        }

        return node.Height;
    }

    /// <summary>
    /// Gets the balance factor of the given node.
    /// </summary>
    /// <param name="node">The node to get the balance factor of.</param>
    /// <returns>The balance factor (left height - right height).</returns>
    private static int GetBalance(Node node)
    {
        if (node == null)
        {
            return 0;
        }

        return GetHeight(node.Left) - GetHeight(node.Right);
    }

    /// <summary>
    /// Performs a right rotation on the given node.
    /// </summary>
    /// <param name="y">The node to rotate around.</param>
    /// <returns>The new root after rotation.</returns>
    private static Node RightRotate(Node y)
    {
        Node x = y.Left;
        Node t2 = x.Right;

        // Perform rotation
        x.Right = y;
        y.Left = t2;

        // Update heights
        y.Height = Math.Max(GetHeight(y.Left), GetHeight(y.Right)) + 1;
        x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right)) + 1;

        // Return new root
        return x;
    }

    /// <summary>
    /// Performs a left rotation on the given node.
    /// </summary>
    /// <param name="x">The node to rotate around.</param>
    /// <returns>The new root after rotation.</returns>
    private static Node LeftRotate(Node x)
    {
        Node y = x.Right;
        Node t2 = y.Left;

        // Perform rotation
        y.Left = x;
        x.Right = t2;

        // Update heights
        x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right)) + 1;
        y.Height = Math.Max(GetHeight(y.Left), GetHeight(y.Right)) + 1;

        // Return new root
        return y;
    }

    /// <summary>
    /// Adds a value to the AVL tree while maintaining the AVL property.
    /// </summary>
    /// <param name="value">The value to add to the tree.</param>
    public void Add(T value)
    {
        if (Root == null)
        {
            Root = new Node(value);
            Count++;
        }
        else
        {
            Root = AddRecursive(Root, value);
        }
    }

    private Node AddRecursive(Node node, T value)
    {
        // Perform standard BST insertion
        if (node == null)
        {
            Count++;
            return new Node(value);
        }

        int comparison = value.CompareTo(node.Value);
        if (comparison < 0)
        {
            if (node.Left != null)
            {
                node.Left = AddRecursive(node.Left, value);
            }
            else
            {
                node.Left = new Node(value);
            }
        }
        else if (comparison > 0)
        {
            if (node.Right != null)
            {
                node.Right = AddRecursive(node.Right, value);
            }
            else
            {
                node.Right = new Node(value);
            }
        }
        else
        {
            // Duplicate values are not allowed in AVL tree
            return node;
        }

        // Update height of current node
        node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));

        // Get the balance factor to check if this node became unbalanced
        int balance = GetBalance(node);

        // If unbalanced, there are 4 cases

        // Left Left Case
        if (balance > 1 && node.Left != null && value.CompareTo(node.Left.Value) < 0)
        {
            return RightRotate(node);
        }

        // Right Right Case
        if (balance < -1 && node.Right != null && value.CompareTo(node.Right.Value) > 0)
        {
            return LeftRotate(node);
        }

        // Left Right Case
        if (balance > 1 && node.Left != null && value.CompareTo(node.Left.Value) > 0)
        {
            node.Left = LeftRotate(node.Left);
            return RightRotate(node);
        }

        // Right Left Case
        if (balance < -1 && node.Right != null && value.CompareTo(node.Right.Value) < 0)
        {
            node.Right = RightRotate(node.Right);
            return LeftRotate(node);
        }

        // Return the unchanged node
        return node;
    }
}




