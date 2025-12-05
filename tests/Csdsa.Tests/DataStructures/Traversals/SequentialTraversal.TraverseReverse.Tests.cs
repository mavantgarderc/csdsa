using System;
using System.Collections.Generic;
using System.IO;
using Csdsa.DataStructures.Traversals;
using Xunit;

namespace Csdsa.Tests.DataStructures.Traversals;

public class SequentialTraversalTraverseReverseTests
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
    public void TravereReverse_WritesElementsInReverseOrder()
    {
        List<string> list = new List<string> { "x", "y", "z" };

        string output = CaptureOutput(() => SequentialTraversal.TravereReverse(list));

        Assert.Equal("z\ny\nx", Normalize(output));
    }
}
