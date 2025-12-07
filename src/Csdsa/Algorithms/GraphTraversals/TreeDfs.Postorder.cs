namespace Csdsa.Algorithms.GraphTraversal;

public static partial class TreeDfs
{
    /// <summary>
    /// Performs a postorder depth-first traversal of the specified binary tree.
    /// </summary>
    /// <param name="root">The root node of the tree.</param>
    /// <returns>
    /// A list of node values visited in postorder (left, right, root).
    /// </returns>
    public static IReadOnlyList<int> Postorder(TreeNode root)
    {
        List<int> result = new List<int>();

        void DfsInternal(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            if (node.Left != null)
            {
                DfsInternal(node.Left);
            }

            if (node.Right != null)
            {
                DfsInternal(node.Right);
            }

            result.Add(node.Val);
        }

        DfsInternal(root);
        return result;
    }
}
