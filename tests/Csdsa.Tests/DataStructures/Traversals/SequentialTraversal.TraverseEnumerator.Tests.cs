using System;
using System.IO;
using Csdsa.DataStructures.Traversals;
using Xunit;

namespace Csdsa.Tests.DataStructures.Traversals;

public class SequentialTraversalTraverseEnumeratorTests
{
    private static readonly string[] CollectionAlphaBeta = { "alpha", "beta" };

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
    public void TraverseEnumerator_WritesAllElements()
    {
        string output = CaptureOutput(() => SequentialTraversal.TraverseEnumerator(CollectionAlphaBeta));

        Assert.Equal("alpha\nbeta", Normalize(output));
    }
}
