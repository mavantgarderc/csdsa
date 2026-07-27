namespace Csdsa.DataStructures.Trees;

public partial class BinarySearchTree<T>
    where T : IComparable<T>, IEquatable<T>
{
    /// <summary>
    /// Performs an inorder traversal of the tree (Left, Root, Right).
    /// This will return values in sorted order for a BST.
    /// </summary>
    /// <returns>An enumerable collection of values in inorder sequence.</returns>
    public IEnumerable<T> InorderTraversal()
    {
        List<T> result = new List<T>();
        InorderTraversalHelper(Root, result);
        return result;
    }


    private static void InorderTraversalHelper(Node node, List<T> result)
    {
        if (node != null)
        {
            if (node.Left != null)
            {
                InorderTraversalHelper(node.Left, result);
            }

            result.Add(node.Value);
            if (node.Right != null)
            {
                InorderTraversalHelper(node.Right, result);
            }
        }
    }


    /// <summary>
    /// Performs a preorder traversal of the tree (Root, Left, Right).
    /// </summary>
    /// <returns>An enumerable collection of values in preorder sequence.</returns>
    public IEnumerable<T> PreorderTraversal()
    {
        List<T> result = new List<T>();
        if (Root != null)
        {
            PreorderTraversalHelper(Root, result);
        }
        return result;
    }

    private static void PreorderTraversalHelper(Node node, List<T> result)
    {
        if (node != null)
        {
            result.Add(node.Value);
            if (node.Left != null)
            {
                PreorderTraversalHelper(node.Left, result);
            }

            if (node.Right != null)
            {
                PreorderTraversalHelper(node.Right, result);
            }

        }

    }

    /// <summary>
    /// Performs a postorder traversal of the tree (Left, Right, Root).
    /// </summary>
    /// <returns>An enumerable collection of values in postorder sequence.</returns>
    public IEnumerable<T> PostorderTraversal()
    {
        List<T> result = new List<T>();
        if (Root != null)
        {
            PostorderTraversalHelper(Root, result);
        }

        return result;
    }


    private static void PostorderTraversalHelper(Node node, List<T> result)
    {
        if (node != null)
        {
            if (node.Left != null)
            {
                PostorderTraversalHelper(node.Left, result);
            }

            if (node.Right != null)
            {
                PostorderTraversalHelper(node.Right, result);
            }

            result.Add(node.Value);
        }
    }

    /// <summary>
    /// Performs a level-order (breadth-first) traversal of the tree.
    /// </summary>
    /// <returns>An enumerable collection of values in level-order sequence.</returns>
    public IEnumerable<T> LevelOrderTraversal()
    {
        if (Root == null)
        {
            yield break;
        }


        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(Root);

        while (queue.Count > 0)
        {
            Node current = queue.Dequeue();
            yield return current.Value;

            if (current.Left != null)
            {
                queue.Enqueue(current.Left);
            }

            if (current.Right != null)
            {
                queue.Enqueue(current.Right);
            }
        }
    }
}
