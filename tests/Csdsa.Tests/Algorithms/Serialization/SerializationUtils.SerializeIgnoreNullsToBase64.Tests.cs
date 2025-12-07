using System.Text;

using Csdsa.Algorithms.Serialization.Json;

using Xunit;

namespace Csdsa.Tests.Algorithms.Serialization.Json;

public sealed partial class SerializationUtilsTests
{
    [Fact]
    public void SerializeIgnoreNullsToBase64_OmitsNullPropertiesInDecodedJson()
    {
        Person person = new Person
        {
            Name = "Base64Test",
            Age = 10,
            Nickname = null,
        };

        string base64 = SerializationUtils.SerializeIgnoreNullsToBase64(person);

        byte[] bytes = Convert.FromBase64String(base64);
        string json = Encoding.UTF8.GetString(bytes);

        Assert.Contains("Base64Test", json);
        Assert.DoesNotContain("Nickname", json);
    }
}
