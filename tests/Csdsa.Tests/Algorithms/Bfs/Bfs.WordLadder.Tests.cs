using System;
using System.Collections.Generic;
using System.Linq;

using Csdsa.Algorithms.GraphTraversal;

using Xunit;

namespace Csdsa.Tests.Algorithms.GraphTraversal;

public sealed partial class BfsTests
{
    [Fact]
    public void WordLadder_Works()
    {
        List<string> wordList = new List<string> { "hot", "dot", "dog", "lot", "log", "cog" };

        int steps = Bfs.WordLadder("hit", "cog", wordList);
        Assert.Equal(5, steps); // hit->hot->dot->dog->cog OR hit->hot->lot->log->cog

        int noPath = Bfs.WordLadder("hit", "zzz", wordList);
        Assert.Equal(0, noPath);
    }
}
