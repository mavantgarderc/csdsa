using System.IO;

using Csdsa.Algorithms.Serialization.Json;

using Xunit;

namespace Csdsa.Tests.Algorithms.Serialization.Json;

public sealed partial class SerializationUtilsTests
{
    [Fact]
    public void SerializeToAndFromNetwork_Works()
    {
        Person person = new Person
        {
            Name = "NetworkTest",
            Age = 99,
        };

        using MemoryStream networkStream = new MemoryStream();

        SerializationUtils.SerializeToNetwork(person, networkStream);

        networkStream.Position = 0;

        Person deserialized = SerializationUtils.DeserializeFromNetwork<Person>(networkStream);

        Assert.Equal("NetworkTest", deserialized.Name);
        Assert.Equal(99, deserialized.Age);
    }
}
