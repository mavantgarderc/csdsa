using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

using Csdsa.Algorithms.Serialization.Json;

using Xunit;

namespace Csdsa.Tests.Algorithms.Serialization.Json;

public sealed partial class SerializationUtilsTests
{
    [Fact]
    public void DeserializeWithConverters_UsesCustomConverter()
    {
        const string json = """
        {
          "Name": "lowercase",
          "Age": 20
        }
        """;

        Person result = SerializationUtils.DeserializeWithConverters(
            json,
            new JsonConverter[] { new UppercaseNameConverter() });

        Assert.Equal("LOWERCASE", result.Name);
        Assert.Equal(20, result.Age);
    }
}
