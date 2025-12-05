using System;
using System.Collections.Generic;
using System.IO;
using Csdsa.DataStructures.Traversals;
using Xunit;

namespace Csdsa.Tests.DataStructures.Traversals;

public class SequentialTraversalTraverseSetTests
{
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
    public void TraverseSet_WritesAllElements()
    {
        HashSet<string> set = new HashSet<string> { "foo", "bar" };

        string output = CaptureOutput(() => SequentialTraversal.TraverseSet(set));

        Assert.Contains("foo", output);
        Assert.Contains("bar", output);
    }
}
