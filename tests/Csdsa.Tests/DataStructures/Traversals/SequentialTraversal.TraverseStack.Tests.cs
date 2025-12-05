using System;
using System.Collections.Generic;
using System.IO;
using Csdsa.DataStructures.Traversals;
using Xunit;

namespace Csdsa.Tests.DataStructures.Traversals;

public class SequentialTraversalTraverseStackTests
{
    private static readonly int[] Collection12 = { 1, 2 };

    private static string Normalize(string s) => s.Replace("\r", "").Trim();

    private static string CaptureOutput(Action action)
    {
        using StringWriter sw = new StringWriter();
        TextWriter originalOut = Console.Out;
        Console.SetOut(sw);

        action();

        Console.SetOut(originalOut);
        return sw.ToString().Trim();
    }

    [Fact]
    public void TraverseStack_WritesFromTopToBottom()
    {
        Stack<int> stack = new Stack<int>(Collection12); // top = 2

        string output = CaptureOutput(() => SequentialTraversal.TraverseStack(stack));

        Assert.Equal("2\n1", Normalize(output));
    }
}
