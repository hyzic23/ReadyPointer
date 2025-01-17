using System.Text.Json.Serialization;

namespace ReadyPointer.API.Models;

public class Data
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Color { get; set; }
    
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Capacity { get; set; }
    
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string CapacityGb { get; set; }
   
    public double Price { get; set; } = 0;
    
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Generation { get; set; }
    
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Year { get; set; }
    
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CPU model")]
    public string CpuModel { get; set; }
    
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Hard disk size")]
    public string HardDiskSize { get; set; }
    
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Strap Colour")]
    public string StrapColor { get; set; }
    
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Case Size")]
    public string CaseSize { get; set; }
    
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Description { get; set; }
   
    [JsonPropertyName("Screen size")]
    public double ScreenSize { get; set; } = 0;
}