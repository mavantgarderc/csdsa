using Csdsa.Algorithms.Serialization.Json;

using Xunit;

namespace Csdsa.Tests.Algorithms.Serialization.Json;

public sealed partial class SerializationUtilsTests
{
    [Fact]
    public void SerializeToAndFromXml_Works()
    {
        Person person = new Person { Name = "Curtis", Age = 49 };

        string xml = SerializationUtils.SerializeToXml(person);
        Person deserialized = SerializationUtils.DeserializeFromXml<Person>(xml);

        Assert.Equal("Curtis", deserialized.Name);
        Assert.Equal(49, deserialized.Age);
    }
}
