using System;
using System.Collections.Generic;
using System.Linq;

using Csdsa.Algorithms.GraphTraversal;

using Xunit;

namespace Csdsa.Tests.Algorithms.GraphTraversal;

public sealed partial class BfsTests
{
    [Fact]
    public void KnightsPath_Works()
    {
        Point start = new Point(0, 0);
        Point end = new Point(1, 2);

        int moves = Bfs.KnightsPath(8, start, end);
        Assert.Equal(1, moves);

        moves = Bfs.KnightsPath(3, new Point(0, 0), new Point(2, 2));
        Assert.Equal(4, moves);
    }
}
