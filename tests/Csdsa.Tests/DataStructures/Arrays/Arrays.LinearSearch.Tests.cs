using Csdsa.DataStructures.Arrays;
using Xunit;
using static Csdsa.DataStructures.Arrays.Arrays;

namespace Csdsa.Tests.DataStructures.Arrays;

public class ArraysLinearSearchTests
{
    [Fact]
    public void LinearSearch_FindsElement()
    {
        int[] input = [10, 20, 30, 40];

        int index = LinearSearch(input, 30);

        Assert.Equal(2, index);
    }

    [Fact]
    public void LinearSearch_FindsAndDoesNotFindElements_AsExpected()
    {
        int[] input = [10, 20, 30];

        Assert.Equal(1, LinearSearch(input, 20));
        Assert.Equal(-1, LinearSearch(input, 99));
    }
}
