using System;
using System.Collections.Generic;
using System.IO;
using Csdsa.DataStructures.Traversals;
using Xunit;

namespace Csdsa.Tests.DataStructures.Traversals;

public class SequentialTraversalTraverseLinkedListTests
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
    public void TraverseLinkedList_WritesElementsInOrder()
    {
        LinkedList<int> list = new LinkedList<int>(new[] { 7, 8 });

        string output = CaptureOutput(() => SequentialTraversal.TraverseLinkedList(list));

        Assert.Equal("7\n8", Normalize(output));
    }
}
