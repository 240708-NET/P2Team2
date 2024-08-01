using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CharacterData.Models
{
    public class Item
    {
        public int id { get; set; } // The item PK in the DB
        public string name { get; set; } // The name of the item
        public double weight { get; set; } // The weight of the item
        public int value {get;set;} // The gold value of the item
        public string typeOfItem { get; set; } // The type of item (melee weapon, ranged weapon, armor, consumable, misc)
        // ^^^ New value used for kindOfWeapon and kindOfArmor (deprecated)
        public string? slotType { get; set; } // The slot that the item is able to be equipped in (head, chest, arms, rightHand, leftHand, twoHanded, legs, ring)
        public bool isEquipped {get; set;} = false;
        public string? description { get; set; } = "No Description Given"; // The description of the equipment
        public int? maxHitPointBonus { get; set; } = 0; 
        public int? currentHitPointBonus { get; set; } = 0;
        public int? meleeDamageBonus { get; set; } = 0;
        public int? rangedDamageBonus { get; set; } = 0;
        public int? magicDamageBonus { get; set; } = 0;
        public int? meleeAttackBonus { get; set; } = 0;
        public int? rangedAttackBonus { get; set; } = 0;
        public int? magicAttackBonus { get; set; } = 0;
        public int? armorClassBonus { get; set; } = 0;
        public string? attackType { get; set; } = "No Attack Type Given"; // The type of attack (slashing, piercing, bludgeoning)
        public string? typeOfDamage { get; set; } = "No Damage Type Given"; // The type of damage (physical, magical, necrotic)
        public int? strRequirement { get; set; } = 0;
        public int? dexRequirement { get; set; } = 0;
        public int? wisRequirement { get; set; } = 0;
        public int? magicRequirement { get; set; } = 0;


        // public string whatIsSlot()
        // {
        //     if (leftHandSlot.HasValue && leftHandSlot.Value == true && rightHandSlot.HasValue && rightHandSlot.Value == true)
        //         return "two-handed";

        //     if (headSlot.HasValue && headSlot.Value == true)
        //         return "head";

        //     if (chestSlot.HasValue && chestSlot.Value == true)
        //         return "chest";

        //     if (armsSlot.HasValue && armsSlot.Value == true)
        //         return "arms";

        //     if (legsSlot.HasValue && legsSlot.Value == true)
        //         return "legs";

        //     if (leftHandSlot.HasValue && leftHandSlot.Value == true)
        //         return "left hand";

        //     if (rightHandSlot.HasValue && rightHandSlot.Value == true)
        //         return "right hand";

        //     if (necklaceSlot.HasValue && necklaceSlot.Value == true)
        //         return "necklace";

        //     if (ringSlot.HasValue && ringSlot.Value == true)
        //         return "ring";

        //     return "None"; // Add a default case to return "None" if no slot is active
        // }

        /*Extra Item To Implement At A Later Date
                public Item greatsword = new Item(){
                    name = "Greatsword",
                    description = "I am a greatsword.",
                    kindOfWeapon = "melee",
                    weight = 15,
                    meleeDamageBonus = 10,
                    attackType = "Slashing",
                    typeOfDamage = "Physical",
                    strRequirement = 15,
                    dexRequirement = 15,
                    rightHandSlot = true,
                    leftHandSlot = true,


                };

                public Item shortsword = new Item(){
                    name = "Shortsword",
                    description = "I am a shortsword.",
                    kindOfWeapon = "melee",
                    weight = 5,
                    meleeDamageBonus = 3,
                    attackType = "Slashing",
                    typeOfDamage = "Physical",
                    strRequirement = 12,
                    dexRequirement = 15,
                    rightHandSlot = true,


                };

                public Item bow = new Item(){
                    name = "Bow",
                    description = "I am a bow.",
                    kindOfWeapon = "ranged",
                    weight = 5,
                    rangedDamageBonus = 5,
                    attackType = "Piercing",
                    typeOfDamage = "Physical",
                    strRequirement = 13,
                    dexRequirement = 15,
                    rightHandSlot = true,
                    leftHandSlot = true,


                };

                public Item leatherChest = new Item(){
                    name = "Leather Armor",
                    description = "I am a leather chest.",
                    kindOfArmor = "medium armor",
                    weight = 5,
                    strRequirement = 10,
                    dexRequirement = 13,
                    armorClassBonus = 3,
                    chestSlot = true,

                };

                public Item clothChest = new Item(){
                    name = "Leather Armor",
                    description = "I am a cloth chest.",
                    kindOfArmor = "light armor",
                    weight = 1,
                    strRequirement = 10,
                    dexRequirement = 10,
                    armorClassBonus = 1,
                    chestSlot = true,

                };

                public Item woodenShield = new Item(){
                    name = "Wooden Shield",
                    description = "I am a wodden shield.",
                    kindOfArmor = "shield",
                    weight = 2,
                    strRequirement = 13,
                    dexRequirement = 12,
                    armorClassBonus = 2,
                    leftHandSlot = true,

                };

                public Item staff = new Item(){
                    name = "Staff",
                    description = "I am a staff.",
                    kindOfWeapon = "melee",
                    weight = 2,
                    magicDamageBonus = 5,
                    meleeDamageBonus = 1,
                    attackType = "bludgeoning",
                    typeOfDamage = "physical",
                    strRequirement = 10,
                    dexRequirement = 10,
                    magicRequirement = 15,
                    rightHandSlot = true,
                    leftHandSlot = true,


                };
        */
    }
}
