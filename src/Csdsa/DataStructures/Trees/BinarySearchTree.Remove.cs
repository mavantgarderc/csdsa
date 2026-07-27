namespace Csdsa.DataStructures.Trees;

public partial class BinarySearchTree<T>
    where T : IComparable<T>, IEquatable<T>
{
    /// <summary>
    /// Finds the node with the minimum value in the subtree rooted at the given node.
    /// </summary>
    /// <param name="node">The root of the subtree.</param>
    /// <returns>The node with the minimum value.</returns>
    private static Node FindMin(Node node)
    {
        while (node.Left != null)
        {
            node = node.Left;
        }

        return node;
    }

    /// <summary>
    /// Removes a value from the binary search tree while maintaining the BST property.
    /// </summary>
    /// <param name="value">The value to remove from the tree.</param>
    /// <returns><see langword="true"/> if the value was found and removed; otherwise, <see langword="false"/>.</returns>
    public bool Remove(T value)
    {
        int initialCount = Count;
        Root = RemoveRecursive(Root, value);
        return initialCount != Count;
    }

    private Node RemoveRecursive(Node node, T value)
    {
        if (node == null)
        {
            return node;
        }

        int comparison = value.CompareTo(node.Value);
        if (comparison < 0)
        {
            if (node.Left != null)
            {
                node.Left = RemoveRecursive(node.Left, value);
            }
        }
        else if (comparison > 0)
        {
            if (node.Right != null)
            {
                node.Right = RemoveRecursive(node.Right, value);
            }
        }
        else
        {
            // Node to delete found
            Count--; // Decrement count since we're removing a node

            // Case 1: Node has no children (leaf node)
            if (node.Left == null && node.Right == null)
            {
                return null;
            }

            // Case 2: Node has one child
            if (node.Left == null)
            {
                return node.Right;
            }

            if (node.Right == null)
            {
                return node.Left;
            }

            // Case 3: Node has two children
            // Find the inorder successor (smallest value in right subtree)
            T successorValue = FindMin(node.Right).Value;
            node.Value = successorValue;
            node.Right = RemoveRecursive(node.Right, successorValue);
        }

        return node;
    }
}
