namespace ReadyPointer.API.Models;

public class Project
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public Data Data { get; set; }
}