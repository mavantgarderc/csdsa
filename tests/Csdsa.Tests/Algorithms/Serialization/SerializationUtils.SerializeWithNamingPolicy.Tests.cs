using System.Text.Json;

using Csdsa.Algorithms.Serialization.Json;

using Xunit;

namespace Csdsa.Tests.Algorithms.Serialization.Json;

public sealed partial class SerializationUtilsTests
{
    [Fact]
    public void SerializeWithNamingPolicy_CamelCase_UsesCamelCasePropertyNames()
    {
        Person person = new Person { Name = "Webster", Age = 34 };

        string json = SerializationUtils.SerializeWithNamingPolicy(person, JsonNamingPolicy.CamelCase);

        Assert.Contains("name", json);
        Assert.Contains("age", json);
    }
}
