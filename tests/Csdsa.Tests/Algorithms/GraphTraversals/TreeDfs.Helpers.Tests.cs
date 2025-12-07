using Csdsa.Algorithms.GraphTraversal;

namespace Csdsa.Tests.Algorithms.GraphTraversals;

public sealed partial class TreeDfsTests
{
    // Builds a simple binary tree:
    //       1
    //      / \
    //     2   3
    //    / \
    //   4   5
    private static TreeNode CreateSampleTree()
    {
        return new TreeNode
        {
            Val = 1,
            Left = new TreeNode
            {
                Val = 2,
                Left = new TreeNode { Val = 4 },
                Right = new TreeNode { Val = 5 },
            },
            Right = new TreeNode
            {
                Val = 3,
                Left = new TreeNode { Val = 6 },
                Right = new TreeNode { Val = 7 },
            },
        };
    }
}
