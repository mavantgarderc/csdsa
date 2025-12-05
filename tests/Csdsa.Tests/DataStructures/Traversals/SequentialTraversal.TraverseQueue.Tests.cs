using System;
using System.Collections.Generic;
using System.IO;
using Csdsa.DataStructures.Traversals;
using Xunit;

namespace Csdsa.Tests.DataStructures.Traversals;

public class SequentialTraversalTraverseQueueTests
{
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
    public void TraverseQueue_WritesInFifoOrder()
    {
        Queue<int> queue = new Queue<int>(new[] { 9, 10 });

        string output = CaptureOutput(() => SequentialTraversal.TraverseQueue(queue));

        Assert.Equal("9\n10", Normalize(output));
    }
}
