using System.Collections.Generic;

using Csdsa.Algorithms.GraphTraversal;

using Xunit;

namespace Csdsa.Tests.Algorithms.GraphTraversals;

public sealed partial class TreeDfsTests
{
    [Fact]
    public void Preorder_ReturnsRootLeftRightOrder()
    {
        TreeNode root = CreateSampleTree();

        IReadOnlyList<int> traversal = TreeDfs.Preorder(root);

        // Expected preorder: 1,2,4,5,3,6,7
        Assert.Equal(new[] { 1, 2, 4, 5, 3, 6, 7 }, traversal);
    }

    [Fact]
    public void Preorder_OnNullRoot_ReturnsEmpty()
    {
        IReadOnlyList<int> traversal = TreeDfs.Preorder(root: null);

        Assert.Empty(traversal);
    }
}
