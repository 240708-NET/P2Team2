namespace PfProj.Models.Characters;

using System.ComponentModel.DataAnnotations;
using PfProj.Entities;

public class UpdateRequestChar
{ 
    // TBI
    // Required Input
    public string name { get; set; } // Name of the character
    public required string characterClassName { get; set; }
    // Optional Input
    public int? level { get; set; } // Level of the character
    public int? experience { get; set; } // Experience points of the character // Class of the character
    public int? currentHitPoints {get; set;} // Current hit points for the character
    private int? maxHitPoints {get; set;} // Max hit points for the character
    private int? armorClass {get; set;} // Armor class for the character
    public int? gold { get; set; } // Gold of the character   
    private int? baseScore {get; set;}
    public int? str {get; set;}
    public int? dex {get; set;}
    public int? wis {get; set;}
    public int? magic {get; set;}
    public int? magicResist {get; set;}
    private int? meleeAttackBonus {get; set;}
    private int? meleeDamageBonus {get; set;}
    private int? rangedAttackBonus {get; set;}
    private int? rangedDamageBonus {get; set;}
    private int? magicAttackBonus {get; set;} 
    private int? magicDamageBonus {get; set;}
    
}
