using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

using Csdsa.Algorithms.Serialization.Json;

using Xunit;

namespace Csdsa.Tests.Algorithms.Serialization.Json;

public sealed partial class SerializationUtilsTests
{
    private sealed class UppercaseNameConverter : JsonConverter<Person>
    {
        public override Person Read(ref Utf8JsonReader reader, System.Type typeToConvert, JsonSerializerOptions options)
        {
            // Minimal read implementation: delegate to default, then adjust.
            Person? person = JsonSerializer.Deserialize<Person>(ref reader, options);
            if (person is null)
            {
                return new Person();
            }

            person.Name = person.Name.ToUpperInvariant();
            return person;
        }

        public override void Write(Utf8JsonWriter writer, Person value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteString(nameof(Person.Name), value.Name.ToUpperInvariant());
            writer.WriteNumber(nameof(Person.Age), value.Age);
            if (value.Nickname is not null)
            {
                writer.WriteString(nameof(Person.Nickname), value.Nickname);
            }

            writer.WriteEndObject();
        }
    }

    [Fact]
    public void SerializeWithConverters_UsesCustomConverter()
    {
        Person person = new Person { Name = "Jayce", Age = 25 };

        string json = SerializationUtils.SerializeWithConverters(
            person,
            new JsonConverter[] { new UppercaseNameConverter() });

        Assert.Contains("JAYCE", json);
        Assert.DoesNotContain("Jayce", json);
    }
}
