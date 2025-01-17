using System.Text.Json.Serialization;

namespace ReadyPointer.API.Models;

public class Product
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Data? Data { get; set; }
}