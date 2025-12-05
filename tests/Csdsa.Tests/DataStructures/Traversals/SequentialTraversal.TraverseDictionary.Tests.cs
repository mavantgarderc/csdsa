using System;
using System.Collections.Generic;
using System.IO;
using Csdsa.DataStructures.Traversals;
using Xunit;

namespace Csdsa.Tests.DataStructures.Traversals;

public class SequentialTraversalTraverseDictionaryTests
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
    public void TraverseDictionary_WritesKeysAndValues()
    {
        Dictionary<string, int> dict = new Dictionary<string, int>
        {
            ["a"] = 1,
            ["b"] = 2,
        };

        string output = CaptureOutput(() => SequentialTraversal.TraverseDictionary(dict));

        Assert.Contains("a: 1", output);
        Assert.Contains("b: 2", output);
    }
}
