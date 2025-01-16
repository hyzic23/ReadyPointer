using System.Text.Json.Serialization;

namespace ReadyPointer.API.Models;

public class Data
{
    public string Color { get; set; } = string.Empty;
    
    public string Capacity { get; set; } = string.Empty;
    
    public double Price { get; set; } = 0;
    
    public string Generation { get; set; } = string.Empty;
    
    public string Year { get; set; } = string.Empty;
    
    [JsonPropertyName("CPU model")]
    public string CpuModel { get; set; } = string.Empty;
    
    [JsonPropertyName("Hard disk size")]
    public string HardDiskSize { get; set; } = string.Empty;
    
    [JsonPropertyName("Strap Colour")]
    public string StrapColor { get; set; } = string.Empty;
    
    [JsonPropertyName("Case Size")]
    public string CaseSize { get; set; } = string.Empty;
    
    public string Description { get; set; } = string.Empty;
    
    [JsonPropertyName("Screen size")]
    public double ScreenSize { get; set; } = 0;
}