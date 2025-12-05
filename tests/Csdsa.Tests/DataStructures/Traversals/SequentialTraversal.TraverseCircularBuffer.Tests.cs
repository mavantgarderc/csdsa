using System;
using System.IO;
using Csdsa.DataStructures.Traversals;
using Xunit;

namespace Csdsa.Tests.DataStructures.Traversals;

public class SequentialTraversalTraverseCircularBufferTests
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
    public void TraverseCircularBuffer_WritesLogicalSequence()
    {
        string[] buffer = { "A", "B", "C", "D" };

        string output = CaptureOutput(() => SequentialTraversal.TraverseCircularBuffer(buffer, 2, 3));

        Assert.Equal("D\nA\nB", Normalize(output));
    }
}
