namespace PfProj.Entities;

using System.Text.Json.Serialization;

public class DataModel
{
    public int Id { get; set; }
    // Required Input
    public required string RequiredInputVar { get; set; }
    // Optional Input
    public int? OptionalInputVar { get; set; }
    // Output (Looks the same as optional inputs here, but we distinquish them by omitting output variables from our request models found in Models/.)
	public int? OutputVar { get; set; }
}
