using Csdsa.Algorithms.Serialization.Json;

using Xunit;

namespace Csdsa.Tests.Algorithms.Serialization.Json;

public sealed partial class SerializationUtilsTests
{
    [Fact]
    public void TryDeserializeOrDefault_ReturnsFallback_OnInvalidJson()
    {
        const string invalidJson = "{ invalid json }";

        Person fallback = new Person { Name = "Fallback", Age = 0 };

        Person result = SerializationUtils.TryDeserializeOrDefault(invalidJson, fallback);

        Assert.Equal("Fallback", result.Name);
        Assert.Equal(0, result.Age);
    }
}
