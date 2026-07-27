namespace Csdsa.DataStructures.Trees;

public partial class BinarySearchTree<T>
    where T : IComparable<T>, IEquatable<T>
{
    /// <summary>
    /// Searches for a value in the binary search tree.
    /// </summary>
    /// <param name="value">The value to search for.</param>
    /// <returns><see langword="true"/> if the value is found; otherwise, <see langword="false"/>.</returns>
    public bool Search(T value)
    {
        return SearchRecursive(Root, value) != null;
    }

    /// <summary>
    /// Finds the node with the specified value in the binary search tree.
    /// </summary>
    /// <param name="value">The value to search for.</param>
    /// <returns>The node containing the value, or <see langword="null"/> if not found.</returns>
    internal Node FindNode(T value)
    {
        return SearchRecursive(Root, value);
    }

    private static Node SearchRecursive(Node node, T value)
    {
        if (node == null)
        {
            return null;
        }

        int comparison = value.CompareTo(node.Value);
        if (comparison == 0)
        {
            return node;
        }
        else if (comparison < 0)
        {
            if (node.Left != null)
            {
                return SearchRecursive(node.Left, value);
            }
            else
            {
                return null;
            }
        }
        else
        {
            if (node.Right != null)
            {
                return SearchRecursive(node.Right, value);
            }
            else
            {
                return null;
            }
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

        Node minNode = FindMin(Root);
        return minNode != null ? minNode.Value : default(T);
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
