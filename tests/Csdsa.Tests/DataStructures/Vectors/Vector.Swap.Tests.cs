using Csdsa.DataStructures.Vectors;
using Xunit;

namespace Csdsa.Tests.DataStructures.Vectors;

public class VectorSwapTests
{
    [Fact]
    public void Swap_ExchangesVectors()
    {
        Vector<double> v1 = new Vector<double>(1, 2);
        Vector<double> v2 = new Vector<double>(3, 4);
        Vector<double> originalV1 = v1;
        Vector<double> originalV2 = v2;

        v1.Swap(ref v2);

        Assert.Equal(originalV1, v2);
        Assert.Equal(originalV2, v1);
    }
}
