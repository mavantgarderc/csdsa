using Csdsa.DataStructures.ArrayList;
using Xunit;

namespace Csdsa.Tests.DataStructures.ArrayList;

public class ArrayListExistsTests
{
    [Fact]
    public void Exists_ReturnsTrueWhenElementExists()
    {
        ArrayList<int> list = new ArrayList<int> { 1, 2, 3 };

        bool exists = list.Exists(x => x == 2);

        Assert.True(exists);
    }

    [Fact]
    public void Exists_ReturnsFalseWhenElementDoesNotExist()
    {
        ArrayList<int> list = new ArrayList<int> { 1, 2, 3 };

        bool exists = list.Exists(x => x == 5);

        Assert.False(exists);
    }
}
