using System;
using System.IO;
using Csdsa.DataStructures.Traversals;
using Xunit;

namespace Csdsa.Tests.DataStructures.Traversals;

public class SequentialTraversalTraverseSpanTests
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
    public void TraverseSpan_WritesElementsInOrder()
    {
        int[] array = { 5, 6, 7 };

        string output = CaptureOutput(() => SequentialTraversal.TraverseSpan(array));

        Assert.Equal("5\n6\n7", Normalize(output));
    }
}
