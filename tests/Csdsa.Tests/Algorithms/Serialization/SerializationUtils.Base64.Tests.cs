using Csdsa.Algorithms.Serialization.Json;

using Xunit;

namespace Csdsa.Tests.Algorithms.Serialization.Json;

public sealed partial class SerializationUtilsTests
{
    [Fact]
    public void SerializeToBase64_And_DeserializeFromBase64_Works()
    {
        Person person = new Person { Name = "Kendrick", Age = 37 };

        string base64 = SerializationUtils.SerializeToBase64(person);
        Person deserialized = SerializationUtils.DeserializeFromBase64<Person>(base64);

        Assert.Equal("Kendrick", deserialized.Name);
        Assert.Equal(37, deserialized.Age);
    }
}
