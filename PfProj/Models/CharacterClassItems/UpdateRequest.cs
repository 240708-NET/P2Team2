namespace PfProj.Models.CharacterClassItems;

using System.ComponentModel.DataAnnotations;
using PfProj.Entities;

public class UpdateRequestClassItem
{ 
    // TBI
    public required string className { get; set; }
    public required int itemID {get; set;}
    
}