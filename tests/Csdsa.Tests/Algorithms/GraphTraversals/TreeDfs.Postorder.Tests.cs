using System.Collections.Generic;

using Csdsa.Algorithms.GraphTraversal;

using Xunit;

namespace Csdsa.Tests.Algorithms.GraphTraversals;

public sealed partial class TreeDfsTests
{
    [Fact]
    public void Postorder_ReturnsLeftRightRootOrder()
    {
        TreeNode root = CreateSampleTree();

        IReadOnlyList<int> traversal = TreeDfs.Postorder(root);

        // Expected postorder: 4,5,2,6,7,3,1
        Assert.Equal(new[] { 4, 5, 2, 6, 7, 3, 1 }, traversal);
    }

    [Fact]
    public void Postorder_OnNullRoot_ReturnsEmpty()
    {
        IReadOnlyList<int> traversal = TreeDfs.Postorder(root: null);

        Assert.Empty(traversal);
    }
}
