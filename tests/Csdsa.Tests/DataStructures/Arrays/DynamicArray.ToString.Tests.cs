using Csdsa.DataStructures.Arrays;
using Xunit;

namespace Csdsa.Tests.DataStructures.Arrays;

public class DynamicArrayToStringTests
{
    [Fact]
    public void DynamicArray_ToString_ReturnsBracketedCommaSeparatedRepresentation()
    {
        DynamicArray<string> array = new DynamicArray<string>();

        array.Add("a");
        array.Add("b");

        Assert.Equal("[a, b]", array.ToString());
    }
}
