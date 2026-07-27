namespace Csdsa.DataStructures.Trees;

public partial class AVLTree<T>
    where T : IComparable<T>, IEquatable<T>
{
    /// <summary>
    /// Gets the node with the minimum value in the subtree rooted at the given node.
    /// </summary>
    /// <param name="node">The root of the subtree.</param>
    /// <returns>The node with the minimum value.</returns>
    private static Node GetMinValueNode(Node node)
    {
        Node current = node;

        // Loop down to find the leftmost leaf
        while (current.Left != null)
        {
            current = current.Left;
        }

        return current;
    }

    /// <summary>
    /// Removes a value from the AVL tree while maintaining the AVL property.
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
        // Perform standard BST deletion
        if (node == null)
        {
            return null;
        }

        int comparison = value.CompareTo(node.Value);
        if (comparison < 0)
        {
            node.Left = RemoveRecursive(node.Left, value);
        }
        else if (comparison > 0)
        {
            node.Right = RemoveRecursive(node.Right, value);
        }
        else
        {
            // Node to be deleted found
            Count--; // Decrement count since we're removing a node

            // Node with only one child or no child
            if (node.Left == null || node.Right == null)
            {
                Node temp = node.Left ?? node.Right;

                if (temp == null)
                {
                    // No child case - return null to indicate node deletion
                    return null;
                }
                else
                {
                    // One child case - return the non-null child
                    return temp;
                }
            }
            else
            {
                // Node with two children: Get the inorder successor (smallest in right subtree)
                Node temp = GetMinValueNode(node.Right);

                // Copy the inorder successor's data to this node
                node.Value = temp.Value;

                // Delete the inorder successor
                node.Right = RemoveRecursive(node.Right, temp.Value);
            }
        }

        // Update height of current node
        node.Height = Math.Max(GetHeight(node.Left), GetHeight(node.Right)) + 1;

        // Get the balance factor of this node to check whether
        // this node became unbalanced
        int balance = GetBalance(node);

        // If this node becomes unbalanced, then there are 4 cases

        // Left Left Case
        if (balance > 1 && GetBalance(node.Left) >= 0)
        {
            return RightRotate(node);
        }

        // Left Right Case
        if (balance > 1 && GetBalance(node.Left) < 0)
        {
            node.Left = LeftRotate(node.Left!);
            return RightRotate(node);
        }

        // Right Right Case
        if (balance < -1 && GetBalance(node.Right) <= 0)
        {
            return LeftRotate(node);
        }

        // Right Left Case
        if (balance < -1 && GetBalance(node.Right) > 0)
        {
            node.Right = RightRotate(node.Right!);
            return LeftRotate(node);
        }

        return node;
    }
}
