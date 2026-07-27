namespace Csdsa.DataStructures.Trees;

public partial class AVLTree<T>
    where T : IComparable<T>, IEquatable<T>
{
    /// <summary>
    /// Searches for a value in the AVL tree.
    /// </summary>
    /// <param name="value">The value to search for.</param>
    /// <returns><see langword="true"/> if the value is found; otherwise, <see langword="false"/>.</returns>
    public bool Search(T value)
    {
        return SearchRecursive(Root, value) != null;
    }

    /// <summary>
    /// Finds the node with the specified value in the AVL tree.
    /// </summary>
    /// <param name="value">The value to search for.</param>
    /// <returns>The node containing the value, or <see langword="null"/> if not found.</returns>
    internal Node FindNode(T value)
    {
        return SearchRecursive(Root, value)!;
    }

    private static Node SearchRecursive(Node node, T value)
    {
        if (node == null)
        {
            return null!;
        }

        int comparison = value.CompareTo(node.Value);
        if (comparison == 0)
        {
            return node;
        }
        else if (comparison < 0)
        {
            return node.Left != null ? SearchRecursive(node.Left, value) : null!;
        }
        else
        {
            return node.Right != null ? SearchRecursive(node.Right, value) : null!;
        }
    }

    /// <summary>
    /// Finds the minimum value in the tree.
    /// </summary>
    /// <returns>The minimum value, or default(T) if the tree is empty.</returns>
    public T FindMin()
    {
        if (Root == null)
        {
            return default(T);
        }

        Node current = Root;
        while (current.Left != null)
        {
            current = current.Left;
        }

        return current.Value;
    }

    /// <summary>
    /// Finds the maximum value in the tree.
    /// </summary>
    /// <returns>The maximum value, or default(T) if the tree is empty.</returns>
    public T FindMax()
    {
        if (Root == null)
        {
            return default(T);
        }

        Node current = Root;
        while (current.Right != null)
        {
            current = current.Right;
        }

        return current.Value;
    }
}
