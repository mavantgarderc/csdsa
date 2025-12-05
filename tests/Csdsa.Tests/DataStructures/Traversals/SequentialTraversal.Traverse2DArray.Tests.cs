using System;
using System.IO;
using Csdsa.DataStructures.Traversals;
using Xunit;

namespace Csdsa.Tests.DataStructures.Traversals;

public class SequentialTraversalTraverse2DArrayTests
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
    public void Traverse2DArray_WritesElementsRowMajor()
    {
        int[,] array = { { 1, 2 }, { 3, 4 } };

        string output = CaptureOutput(() => SequentialTraversal.Traverse2DArray(array));

        Assert.Equal("1\n2\n3\n4", Normalize(output));
    }
}
