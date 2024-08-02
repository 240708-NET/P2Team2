namespace PfProj.Models.DataModels;

using System.ComponentModel.DataAnnotations;
using PfProj.Entities;

public class UpdateRequest
{ 
    // May not work, I will figure this out. In the meantime rely on POST/GET to test your functionality -C
    public required string RequiredInputVar { get; set; }
    public int? OptionalInputVar{ get; set; }
    
}
