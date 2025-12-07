using Csdsa.Algorithms.Serialization.Json;

using Xunit;

namespace Csdsa.Tests.Algorithms.Serialization.Json;

public sealed partial class SerializationUtilsTests
{
    private abstract class Animal
    {
        public string Name { get; set; } = string.Empty;
    }

    private sealed class Dog : Animal
    {
        public int Age { get; set; }
    }

    [Fact]
    public void SerializePolymorphic_And_DeserializePolymorphic_Works()
    {
        Dog dog = new Dog
        {
            Name = "Snoopy",
            Age = 5,
        };

        string json = SerializationUtils.SerializePolymorphic<Animal>(dog);
        Dog deserialized = SerializationUtils.DeserializePolymorphic<Dog>(json);

        Assert.Equal("Snoopy", deserialized.Name);
        Assert.Equal(5, deserialized.Age);
    }
}
