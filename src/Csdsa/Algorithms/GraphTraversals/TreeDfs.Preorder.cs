namespace Csdsa.Algorithms.GraphTraversal;

public static partial class TreeDfs
{
    /// <summary>
    /// Performs a preorder depth-first traversal of the specified binary tree.
    /// </summary>
    /// <param name="root">The root node of the tree.</param>
    /// <returns>
    /// A list of node values visited in preorder (root, left, right).
    /// </returns>
    public static IReadOnlyList<int> Preorder(TreeNode root)
    {
        List<int> result = new List<int>();

        void DfsInternal(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            result.Add(node.Val);

            if (node.Left != null)
            {
                DfsInternal(node.Left);
            }

            if (node.Right != null)
            {
                DfsInternal(node.Right);
            }
        }

        DfsInternal(root);
        return result;
    }
}
