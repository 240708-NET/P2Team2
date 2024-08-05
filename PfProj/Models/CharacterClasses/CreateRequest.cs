namespace PfProj.Models.CharacterClasses;

using System.ComponentModel.DataAnnotations;
using PfProj.Entities;

public class CreateRequest
{
    public required string className { get; set; }
    public required int dex { get; set; }
    public required int str { get; set; }
    public required int wis { get; set; }
    public required int magic { get; set; }
    public required int magicResist { get; set; }
    // Optional Input
    public int? baseScore { get; set; }
}
