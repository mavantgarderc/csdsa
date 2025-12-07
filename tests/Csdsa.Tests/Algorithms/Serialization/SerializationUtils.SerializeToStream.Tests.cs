using System.IO;

using Csdsa.Algorithms.Serialization.Json;

using Xunit;

namespace Csdsa.Tests.Algorithms.Serialization.Json;

public sealed partial class SerializationUtilsTests
{
    [Fact]
    public void SerializeToAndFromStream_Works()
    {
        Person person = new Person { Name = "Dwayne", Age = 42 };

        using MemoryStream stream = new MemoryStream();

        SerializationUtils.SerializeToStream(person, stream);
        stream.Position = 0;

        Person deserialized = SerializationUtils.DeserializeFromStream<Person>(stream);

        Assert.Equal("Dwayne", deserialized.Name);
        Assert.Equal(42, deserialized.Age);
    }
}
