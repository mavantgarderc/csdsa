using System;
using System.Collections.Generic;
using System.IO;
using Csdsa.DataStructures.Traversals;
using Xunit;

namespace Csdsa.Tests.DataStructures.Traversals;

public class SequentialTraversalTraverseListTests
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
    public void TraverseList_WritesElementsInOrder()
    {
        string output = CaptureOutput(() => SequentialTraversal.TraverseList(new List<int> { 4, 5 }));

        Assert.Equal("4\n5", Normalize(output));
    }
}
