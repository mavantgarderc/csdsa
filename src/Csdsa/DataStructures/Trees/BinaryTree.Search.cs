namespace Csdsa.DataStructures.Trees;

public partial class BinaryTree<T>
    where T : IComparable<T>, IEquatable<T>
{
    /// <summary>
    /// Searches for a value in the tree using level-order traversal.
    /// </summary>
    /// <param name="value">The value to search for.</param>
    /// <returns><see langword="true"/> if the value is found; otherwise, <see langword="false"/>.</returns>
    public bool Search(T value)
    {
        if (Root == null)
        {
            return false;
        }

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(Root);

        while (queue.Count > 0)
        {
            Node current = queue.Dequeue();

            if (current.Value.Equals(value))
            {
                return true;
            }

            if (current.Left != null)
            {
                queue.Enqueue(current.Left);
            }

            if (current.Right != null)
            {
                queue.Enqueue(current.Right);
            }
        }

        return false;
    }

    /// <summary>
    /// Finds the node with the specified value using level-order traversal.
    /// </summary>
    /// <param name="value">The value to search for.</param>
    /// <returns>The node containing the value, or <see langword="null"/> if not found.</returns>
    internal Node FindNode(T value)
    {
        if (Root == null)
        {
            return null;
        }

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(Root);

        while (queue.Count > 0)
        {
            Node current = queue.Dequeue();

            if (current.Value.Equals(value))
            {
                return current;
            }

            if (current.Left != null)
            {
                queue.Enqueue(current.Left);
            }

            if (current.Right != null)
            {
                queue.Enqueue(current.Right);
            }
        }

        return null;
    }
}
