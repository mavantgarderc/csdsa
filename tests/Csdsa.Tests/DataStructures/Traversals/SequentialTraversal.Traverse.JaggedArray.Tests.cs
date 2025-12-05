using System;
using System.IO;
using Csdsa.DataStructures.Traversals;
using Xunit;

namespace Csdsa.Tests.DataStructures.Traversals;

public class SequentialTraversalTraverseJaggedArrayTests
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
    public void TraverseJaggedArray_WritesAllElements()
    {
        int[][] jagged =
        {
            new[] { 1, 2 },
            new[] { 3 },
        };

        string output = CaptureOutput(() => SequentialTraversal.TraverseJaggedArray(jagged));

        Assert.Equal("1\n2\n3", Normalize(output));
    }
}
