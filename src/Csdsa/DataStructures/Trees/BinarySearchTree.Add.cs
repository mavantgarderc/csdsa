namespace Csdsa.DataStructures.Trees;

public partial class BinarySearchTree<T>
    where T : IComparable<T>, IEquatable<T>
{
    /// <summary>
    /// Adds a value to the binary search tree while maintaining the BST property.
    /// </summary>
    /// <param name="value">The value to add to the tree.</param>
    public void Add(T value)
    {
        Root = AddRecursive(Root, value);
    }

    private Node AddRecursive(Node node, T value)
    {
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

        // If values are equal, we don't add (no duplicates in BST)
        return node;
    }
}
