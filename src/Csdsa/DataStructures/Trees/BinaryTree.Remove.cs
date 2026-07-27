namespace Csdsa.DataStructures.Trees;

public partial class BinaryTree<T>
    where T : IComparable<T>, IEquatable<T>
{
    /// <summary>
    /// Removes a node with the specified value from the tree.
    /// This implementation removes the first occurrence found using level-order traversal.
    /// </summary>
    /// <param name="value">The value to remove from the tree.</param>
    /// <returns><see langword="true"/> if the value was found and removed; otherwise, <see langword="false"/>.</returns>
    public bool Remove(T value)
    {
        if (Root == null)
        {
            return false;
        }

        // Find the node to delete and the deepest rightmost node
        Node nodeToDelete = null;
        Node deepestNode = null;
        Node parentOfDeepest = null;

        Queue<(Node Node, Node Parent)> queue = new Queue<(Node Node, Node Parent)>();
        queue.Enqueue((Root, null));

        while (queue.Count > 0)
        {
            var (Node, Parent) = queue.Dequeue();
            deepestNode = Node;
            parentOfDeepest = Parent;

            if (Node.Value.Equals(value) && nodeToDelete == null)
            {
                nodeToDelete = Node;
            }

            if (Node.Left != null)
            {
                queue.Enqueue((Node.Left, Node));
            }

            if (Node.Right != null)
            {
                queue.Enqueue((Node.Right, Node));
            }
        }

        if (nodeToDelete == null)
        {
            return false; // Value not found
        }

        // Replace the value of node to delete with the deepest node's value
        nodeToDelete.Value = deepestNode!.Value;

        // Remove the deepest node
        if (parentOfDeepest != null)
        {
            if (parentOfDeepest.Right == deepestNode)
            {
                parentOfDeepest.Right = null;
            }
            else
            {
                parentOfDeepest.Left = null;
            }
        }
        else
        {
            // The tree had only one node
            Root = null;
        }

        Count--;
        return true;
    }
}
