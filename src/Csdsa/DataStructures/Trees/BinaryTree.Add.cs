namespace Csdsa.DataStructures.Trees;

public partial class BinaryTree<T>
    where T : IComparable<T>, IEquatable<T>
{
    /// <summary>
    /// Adds a value to the tree using level-order insertion (breadth-first).
    /// </summary>
    /// <param name="value">The value to add to the tree.</param>
    public void Add(T value)
    {
        Node newNode = new Node(value);

        if (Root == null)
        {
            Root = newNode;
            Count++;
            return;
        }

        // Use level-order traversal to find the first empty spot
        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(Root);

        while (queue.Count > 0)
        {
            Node current = queue.Dequeue();

            if (current.Left == null)
            {
                current.Left = newNode;
                Count++;
                return;
            }
            else
            {
                queue.Enqueue(current.Left);
            }

            if (current.Right == null)
            {
                current.Right = newNode;
                Count++;
                return;
            }
            else
            {
                queue.Enqueue(current.Right);
            }
        }
    }
}
