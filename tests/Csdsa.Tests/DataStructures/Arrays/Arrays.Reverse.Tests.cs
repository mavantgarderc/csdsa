using Csdsa.DataStructures.Arrays;
using Xunit;
using static Csdsa.DataStructures.Arrays.Arrays;

namespace Csdsa.Tests.DataStructures.Arrays;

public class ArraysReverseTests
{
    [Fact]
    public void Reverse_Generic_ReversesArrayInPlace()
    {
        string[] input = ["a", "b", "c"];
        string[] expected = ["c", "b", "a"];

        Reverse(input);

        Assert.Equal(expected, input);
    }
}
