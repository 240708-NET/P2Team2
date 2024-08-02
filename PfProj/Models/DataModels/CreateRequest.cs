namespace PfProj.Models.DataModels;

using System.ComponentModel.DataAnnotations;
using PfProj.Entities;

public class CreateRequest
{
    public required string RequiredInputVar { get; set; }
    public int? OptionalInputVar{ get; set; }
}
