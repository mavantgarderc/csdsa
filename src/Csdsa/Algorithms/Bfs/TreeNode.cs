namespace Csdsa.Algorithms.GraphTraversal;

/// <summary>Represents a node in a binary tree with integer values.</summary>
public sealed class TreeNode
{
    /// <summary>Gets or sets the value stored at this node.</summary>
    public int Val { get; set; }

    /// <summary>Gets or sets the left child node.</summary>
    required public TreeNode Left { get; set; }

    /// <summary>Gets or sets the right child node.</summary>
    required public TreeNode Right { get; set; }
}
