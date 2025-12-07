using Csdsa.Algorithms.Serialization.Json;

using Xunit;

namespace Csdsa.Tests.Algorithms.Serialization.Json;

public sealed partial class SerializationUtilsTests
{
    private sealed class PrivatePerson
    {
        public string Name { get; set; } = string.Empty;

        private string Secret { get; set; } = "top-secret";
    }

    [Fact]
    public void SerializeIncludingPrivate_ProducesJson()
    {
        PrivatePerson person = new PrivatePerson
        {
            Name = "Test",
        };

        string json = SerializationUtils.SerializeIncludingPrivate(person);

        Assert.False(string.IsNullOrWhiteSpace(json));
        Assert.Contains("Test", json);
    }
}
