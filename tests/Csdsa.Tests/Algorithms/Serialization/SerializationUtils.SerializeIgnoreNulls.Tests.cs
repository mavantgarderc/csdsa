using Csdsa.Algorithms.Serialization.Json;

using Xunit;

namespace Csdsa.Tests.Algorithms.Serialization.Json;

public sealed partial class SerializationUtilsTests
{
    [Fact]
    public void SerializeIgnoreNulls_OmitsNullProperties()
    {
        Person person = new Person { Name = "Aubrey", Age = 38 };

        string json = SerializationUtils.SerializeIgnoreNulls(person);

        Assert.DoesNotContain("Nickname", json);
    }
}
