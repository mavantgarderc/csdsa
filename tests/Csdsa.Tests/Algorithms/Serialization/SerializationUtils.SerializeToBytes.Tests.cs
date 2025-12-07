using Csdsa.Algorithms.Serialization.Json;

using Xunit;

namespace Csdsa.Tests.Algorithms.Serialization.Json;

public sealed partial class SerializationUtilsTests
{
    [Fact]
    public void SerializeToAndFromBytes_Works()
    {
        Person person = new Person { Name = "Ye", Age = 48 };

        byte[] bytes = SerializationUtils.SerializeToBytes(person);
        Person deserialized = SerializationUtils.DeserializeFromBytes<Person>(bytes);

        Assert.Equal("Ye", deserialized.Name);
        Assert.Equal(48, deserialized.Age);
    }
}
