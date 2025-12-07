namespace Csdsa.Tests.Algorithms.Serialization.Json;

public sealed partial class SerializationUtilsTests
{
    public sealed class Person
    {
        public string Name { get; set; } = "mavantgarderc";

        public int Age { get; set; } = 22;

        public string? Nickname { get; set; }
    }
}
