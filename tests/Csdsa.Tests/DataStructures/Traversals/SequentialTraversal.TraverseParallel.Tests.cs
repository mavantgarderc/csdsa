using System;
using System.IO;
using Csdsa.DataStructures.Traversals;
using Xunit;

namespace Csdsa.Tests.DataStructures.Traversals;

public class SequentialTraversalTraverseParallelTests
{
    private static readonly string[] CollectionAbc = { "a", "b", "c" };

    private static string CaptureOutput(Action action)
    {
        using StringWriter sw = new StringWriter();
        TextWriter originalOut = Console.Out;
        Console.SetOut(sw);

        action();

        Console.SetOut(originalOut);
        return sw.ToString();
    }

    [Fact]
    public void TraverseParallel_WritesAllElements_AnyOrder()
    {
        string output = CaptureOutput(() => SequentialTraversal.TraverseParallel(CollectionAbc));

        Assert.Contains("a", output);
        Assert.Contains("b", output);
        Assert.Contains("c", output);
    }
}
