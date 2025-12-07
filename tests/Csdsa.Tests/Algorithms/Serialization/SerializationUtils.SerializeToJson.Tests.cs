using Csdsa.Algorithms.Serialization.Json;

using Xunit;

namespace Csdsa.Tests.Algorithms.Serialization.Json;

public sealed partial class SerializationUtilsTests
{
    [Fact]
    public void SerializeAndDeserialize_ReturnsEqualObject()
    {
        Person person = new Person { Name = "Jermaine", Age = 40 };

        string json = SerializationUtils.SerializeToJson(person);
        Person deserialized = SerializationUtils.DeserializeFromJson<Person>(json);

        Assert.Equal(person.Name, deserialized.Name);
        Assert.Equal(person.Age, deserialized.Age);
    }
}
