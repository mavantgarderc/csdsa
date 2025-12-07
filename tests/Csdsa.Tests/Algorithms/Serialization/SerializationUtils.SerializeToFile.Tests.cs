using System.IO;

using Csdsa.Algorithms.Serialization.Json;

using Xunit;

namespace Csdsa.Tests.Algorithms.Serialization.Json;

public sealed partial class SerializationUtilsTests
{
    [Fact]
    public void SerializeToAndFromFile_Works()
    {
        Person person = new Person { Name = "Shawn", Age = 55 };
        const string path = "temp-test.json";

        SerializationUtils.SerializeToFile(person, path);
        Person deserialized = SerializationUtils.DeserializeFromFile<Person>(path);

        File.Delete(path);

        Assert.Equal("Shawn", deserialized.Name);
        Assert.Equal(55, deserialized.Age);
    }
}
