using Csdsa.Algorithms.Serialization.Json;

using Xunit;

namespace Csdsa.Tests.Algorithms.Serialization.Json;

public sealed partial class SerializationUtilsTests
{
    [Fact]
    public void IsValidJson_ReturnsTrueForValidJson_AndFalseForInvalid()
    {
        Person person = new Person { Name = "Nayvadius", Age = 41 };

        string json = SerializationUtils.SerializeToJson(person);

        Assert.True(SerializationUtils.IsValidJson(json));
        Assert.False(SerializationUtils.IsValidJson("Invalid JSON"));
    }
}
