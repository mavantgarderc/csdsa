using System;
using System.IO;
using Csdsa.DataStructures.Traversals;
using Xunit;

namespace Csdsa.Tests.DataStructures.Traversals;

public class SequentialTraversalTraverseWithIndexTests
{
    private static readonly string[] CollectionAb = { "a", "b" };

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
    public void TraverseWithIndex_PrintsIndexAndValue()
    {
        string output = CaptureOutput(() => SequentialTraversal.TraverseWithIndex(CollectionAb));

        Assert.Equal("[0] = a\n[1] = b", Normalize(output));
    }
}
