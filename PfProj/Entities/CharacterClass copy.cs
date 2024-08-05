namespace PfProj.Entities;

using System.Text.Json.Serialization;

public class CharacterClass
{
    public int Id { get; set; }
    // Required Input
    public required string className { get; set; }
    public required int dex { get; set; }
    public required int str { get; set; }
    public required int wis { get; set; }
    public required int magic { get; set; }
    public required int magicResist { get; set; }
    // Optional Input
    public int? baseScore { get; set; } = 10;
    // Output (Looks the same as optional inputs here, but we distinquish them by omitting output variables from our request models found in Models/.)
}
