using Csdsa.Algorithms.Serialization.Json;

using Xunit;

namespace Csdsa.Tests.Algorithms.Serialization.Json;

public sealed partial class SerializationUtilsTests
{
    [Fact]
    public void DeepClone_CreatesNewObject_WithSameValues()
    {
        Person person = new Person { Name = "Lelland", Age = 31 };

        Person clone = SerializationUtils.DeepClone(person);

        Assert.NotSame(person, clone);
        Assert.Equal("Lelland", clone.Name);
        Assert.Equal(31, clone.Age);
    }
}
