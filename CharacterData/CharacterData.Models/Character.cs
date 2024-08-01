using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace CharacterData.Models
{
    public class Character
    {
        public List<Item> inventory { get; set; }

        //Character Properties from the Character class
        public int id { get; set; } // Unique identifier for the character
        public string? name { get; set; } = ""; // Name of the character
        public int level { get; set; } = 1; // Level of the character
        public int experience { get; set; } = 0; // Experience points of the character
        public string characterClassName { get; set; } = ""; // Class of the character
        public int currentHitPoints {get; set;} = 0; // Current hit points for the character
        private int maxHitPoints {get; set;} = 0; // Max hit points for the character
        private int armorClass {get; set;} = 0; // Armor class for the character
        public int gold { get; set; } = 0; // Gold of the character   

        //Ability Scores
        private int baseScore = 10;
        public int str {get; set;} = baseScore;
        public int dex {get; set;} = baseScore;
        public int wis {get; set;} = baseScore;
        public int magic {get; set;} = baseScore;
        public int magicResist {get; set;} = baseScore;

        //Attack Bonusses and Damage Bonuses
        private int meleeAttackBonus {get; set;} = 0;
        private int meleeDamageBonus {get; set;} = 0;
        private int rangedAttackBonus {get; set;} = 0;
        private int rangedDamageBonus {get; set;} = 0;
        private int magicAttackBonus {get; set;} = 0;
        private int magicDamageBonus {get; set;} = 0;
        
        //Character properties from other classes
        private CharacterClass? characterClass { get; set; }

        public Character() { }

        public Character(CharacterClass newCharacterClass)
        {
            this.characterClass = newCharacterClass;

            this.inventory = new List<Item>();

            experience = 0;
            level = 1;
            gold = 500;
            this.characterClassName = this.characterClass.className;

            this.dex = characterClass.dex;
            this.str = characterClass.str;
            this.wis = characterClass.wis;
            this.magic = characterClass.magic;
            this.magicResist = characterClass.magicResist;

            armorClass = (this.dex + this.str);
            maxHitPoints = (this.str + this.wis);

            this.magicDamageBonus = this.magic - 10;
            this.magicAttackBonus = (this.wis - 10) + (this.magic - 10);

            this.meleeDamageBonus = this.str - 10;
            this.meleeAttackBonus = (this.str - 10) + (this.dex - 10);

            this.rangedDamageBonus = (this.dex - 10);
            this.rangedAttackBonus = (this.str - 10) + (this.dex - 10);
        }

        /// <summary>
        /// Increases the level of the character and adjusts ability scores accordingly based on the character's class.
        /// </summary>
        /// <remarks>
        /// The method increments the character's level by one and resets the experience points to zero. It then displays a congratulatory message for leveling up.
        /// Depending on the character's class (Wizard, Fighter, Shadow Weaver), specific ability scores are increased by 3 points, and the player can allocate an additional point to any other ability score.
        /// The player is prompted to choose which ability score to increase and the method handles the allocation accordingly.
        /// </remarks>
        public void LevelUp()
        {
            bool exit = false;
            string choice = "";
            level++;
            experience = 0;

            Console.Clear();

            Console.WriteLine($"\nCongratulations! You have just leveled up from {level - 1} to {level}!");
            Console.WriteLine($"------------------------------------------------------");

            if (characterClassName.ToLower() == "wizard")
            {
                this.wis += 3;
                this.magic += 3;
                Console.WriteLine($"As a {characterClassName}, your Wisdom and Magic ability scores increased by 3 and you get 1 additional point to add to any other ability score.\n");

                exit = false;
                while (!exit)
                {
                    Console.WriteLine($"Your Current Ability Scores Are Now:");
                    Console.WriteLine($"Str: {this.str} \nDex: {this.dex} \nWis: {this.wis} \nMagic: {this.magic} \nMagic Resistance: {this.magicResist}\n");

                    Console.WriteLine("Which Ability Score Would You Like To Increase?");
                    Console.WriteLine("1. Str");
                    Console.WriteLine("2. Dex");
                    Console.WriteLine("3. Wis");
                    Console.WriteLine("4. Magic");
                    Console.WriteLine("5. Magic Resistance");
                    Console.Write("Choose An Ability Score: ");
                    choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            {
                                this.str++;
                                exit = true;
                                break;
                            }
                        case "2":
                            {
                                this.dex++;
                                exit = true;
                                break;
                            }
                        case "3":
                            {
                                this.wis++;
                                exit = true;
                                break;
                            }
                        case "4":
                            {
                                this.magic++;
                                exit = true;
                                break;
                            }
                        case "5":
                            {

                                this.magicResist++;
                                exit = true;
                                break;
                            }
                        default:
                            {
                                Console.Clear();
                                Console.WriteLine("\n***Invalid choice. Please Choose Again.***\n");
                                break;
                            }
                    }
                }
                Console.Clear();
                Console.WriteLine($"Congratulations, you have finished leveling up.");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("What's next adventurer?\n");
            }

            if (characterClassName.ToLower() == "fighter")
            {
                this.str += 3;
                this.magicResist += 3;

                Console.WriteLine($"As a {characterClassName}, your Strength and Magic Resist ability scores increased by 3 and you get 1 additional point to add to any other ability score.\n");

                exit = false;
                while (!exit)
                {
                    Console.WriteLine($"Your Current Ability Scores Are Now:");
                    Console.WriteLine($"Str: {this.str}, \nDex: {this.dex}, \nWis: {this.wis} \nMagic: {this.magic}, \nMagic Resistance: {this.magicResist}\n");

                    Console.WriteLine("Which Ability Score Would You Like To Increase?");
                    Console.WriteLine("1. Str");
                    Console.WriteLine("2. Dex");
                    Console.WriteLine("3. Wis");
                    Console.WriteLine("4. Magic");
                    Console.WriteLine("5. Magic Resistance");
                    Console.Write("Choose An Ability Score: ");
                    choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            {
                                this.str++;
                                exit = true;
                                break;
                            }
                        case "2":
                            {
                                this.dex++;
                                exit = true;
                                break;
                            }
                        case "3":
                            {
                                this.wis++;
                                exit = true;
                                break;
                            }
                        case "4":
                            {
                                this.magic++;
                                exit = true;
                                break;
                            }
                        case "5":
                            {
                                this.magicResist++;
                                exit = true;
                                break;
                            }
                        default:
                            {
                                Console.Clear();
                                Console.WriteLine("\n***Invalid choice. Please Choose Again.***\n");
                                break;
                            }
                    }
                }

                Console.Clear();
                Console.WriteLine($"Congratulations, you have finished leveling up.");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("What's next adventurer?\n");
            }

            if (characterClassName.ToLower() == "shadow weaver")
            {
                this.dex += 3;
                this.magic += 3;
                Console.WriteLine($"I see you are a {characterClassName}!");
                Console.WriteLine($"\nYour Current Ability Scores Are Now:");
                Console.WriteLine($"Str: {this.str}, \nDex: {this.dex}, \nWis: {this.wis} \nMagic: {this.magic}, \nMagic Resistance: {this.magicResist}\n");

                exit = false;
                while (!exit)
                {
                    Console.WriteLine($"As a {characterClassName}, your Dexterity and Magic ability scores increased by 3 and you get 1 additional point to add to any other ability score.\n");

                    Console.WriteLine("Which Ability Score Would You Like To Increase?");
                    Console.WriteLine("1. Str");
                    Console.WriteLine("2. Dex");
                    Console.WriteLine("3. Wis");
                    Console.WriteLine("4. Magic");
                    Console.WriteLine("5. Magic Resistance");
                    Console.Write("Choose An Ability Score: ");
                    choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            {
                                this.str++;
                                exit = true;
                                break;
                            }
                        case "2":
                            {
                                this.dex++;
                                exit = true;
                                break;
                            }
                        case "3":
                            {
                                this.wis++;
                                exit = true;
                                break;
                            }
                        case "4":
                            {
                                this.magic++;
                                exit = true;
                                break;
                            }
                        case "5":
                            {
                                this.magicResist++;
                                exit = true;
                                break;
                            }
                        default:
                            {
                                Console.Clear();
                                Console.WriteLine("\n***Invalid choice. Please Choose Again.***\n");
                                break;
                            }
                    }
                }
            }
        }

        /// <summary>Displays the names of items in the inventory.</summary>
        /// <returns>A string containing the names of items in the inventory.</returns>
        public string displayInventory()
        {
            string inventoryItemList = "";

            foreach (Item e in inventory)
            {
                if (e == null) { }
                else
                    inventoryItemList += (e.name + " ");
            }

            return inventoryItemList;
        }


        /// <summary>
        /// Display the currently equipped items.
        /// </summary>
        /// <returns>A string representing the currently equipped items.</returns>
        public string displayEquipped()
        {
            string equippedItemList = "";

            foreach (Item e in inventory)
            {
                if (e.isEquipped == true)
                    equippedItemList += (e.name + " ");
            }

            return equippedItemList;
        }

        //This method adds an equipment object to the inventory list
        public void AddToInventory(Item equipment)
        {
            //Add the equipment object to the inventory list
            inventory.Add(equipment);
        }

        public void RemoveFromInventory(Item equipment)
        {
            inventory.Remove(equipment);
        }

        public bool EquipItem(Item equipment)
        {
            if (inventory.Contains(equipment) && equipment.isEquipped == false)
            {
                foreach (Item p in inventory)
                {
                    if (p.whatIsSlot() == equipment.whatIsSlot())
                    {
                        UnequipItem( inventory[ inventory.IndexOf(p) ] );
                        inventory[ inventory.IndexOf(p) ].isEquipped = true;
                        UpdateCharacterStats(equipment);
                        return true;
                    }
                    else
                    {
                        inventory[ inventory.IndexOf(p) ].isEquipped = true;
                        UpdateCharacterStats(equipment);
                        return true;
                    }
                }
            }
            return false;
        }

        public bool UnequipItem(Item equippedItem)
        {
            if (inventory.Contains(equippedItem) && equippedItem.isEquipped == true)
            {
                inventory[ inventory.IndexOf(equippedItem) ].isEquipped = false;
                // Clear the equipped slot
                UpdateCharacterStats(inventory[ inventory.IndexOf(equippedItem) ], false); // Update stats with negative equipment bonuses
                return true;
            }
            return false;
        }

        
        //NEED TO IMPLEMENT EVENTUALLY
        // private bool CanEquip(Item equipment) // Replace with actual logic for character checks
        // {
        //     // Implement checks based on character class, stats, etc.
        //     return true; // Replace with actual implementation
        // }

        public void UpdateCharacterStats(Item equipment, bool isEquipping = true)
        {
            // Update character stats based on equipment bonuses (positive or negative based on isEquipping)

            // Update character stats based on equipment bonuses/penalties
            if (isEquipping)
            {
                armorClass.AC += equipment.armorClassBonus;

                this.meleeAttackBonus += equipment.meleeAttackBonus;

                this.meleeDamageBonus += equipment.meleeDamageBonus;

                this.rangedAttackBonus += equipment.rangedAttackBonus;

                this.rangedDamageBonus += equipment.rangedDamageBonus;

                this.magicAttackBonus += equipment.magicAttackBonus;

                this.magicDamageBonus += equipment.magicDamageBonus;

                this.maxHitPoints += equipment.maxHitPointBonus;

                this.currentHitPoints += equipment.currentHitPointBonus;
            }
            else
            {
                armorClass.AC -= equipment.armorClassBonus;

                this.meleeAttackBonus -= equipment.meleeAttackBonus;

                this.meleeDamageBonus -= equipment.meleeDamageBonus;

                this.rangedAttackBonus -= equipment.rangedAttackBonus;

                this.rangedDamageBonus -= equipment.rangedDamageBonus;

                this.magicAttackBonus -= equipment.magicAttackBonus;

                this.magicDamageBonus -= equipment.magicDamageBonus;

                this.maxHitPoints -= equipment.maxHitPointBonus;

                this.currentHitPoints -= equipment.currentHitPointBonus;
            }
        }

        public void DisplayCharacter()
        {
            // Get the strings for the inventory and equipped items
            string inventoryDisplay = displayInventory();
            string equippedDisplay = displayEquipped();

            // Display message to the user
            //Message for the User
            Console.WriteLine($"{this.name}'s Character Sheet:");
            Console.WriteLine("----------------------------------------\n");

            string characterSheet =
    "╔═════════════════════════════════════════════════╗\n" +
    "║                Character Sheet                  ║\n" +
    "╠═════════════════════════════════════════════════╣\n" +
    $"║ Name: {name}         Class: {this.characterClassName}       ║\n" +
    $"║ Level: {this.level}                   XP: {this.experience}                ║\n" +
    "╠═════════════════════════════════════════════════╣\n" +
    $"║  - Max HP: {this.maxHitPoints}                                       ║\n" +
    $"║  - AC: {this.armorClass.AC}                                       ║\n" +
    "╠═════════════════════════════════════════════════╣\n" +
    "║                Ability Scores                   ║\n" +
    $"║  - Str: {this.str}                    - Magic: {this.magic}       ║\n" +
    $"║  - Dex: {this.dex}                    - Magic Res: {this.magicResist}   ║\n" +
    $"║  - Wis: {this.wis}                                      ║\n" +
    "╠═════════════════════════════════════════════════╣\n" +
    "║                  Attack Bonuses                 ║\n" +
    $"║  - Melee Attack Bonus:  +{this.meleeAttackBonus}                      ║\n" +
    $"║  - Melee Damage Bonus:  +{this.meleeDamageBonus}                      ║\n" +
    $"║-------------------------------------------------║\n" +
    $"║  - Ranged Attack Bonus: +{this.rangedAttackBonus}                      ║\n" +
    $"║  - Ranged Damage Bonus: +{this.rangedDamageBonus}                      ║\n" +
    $"║-------------------------------------------------║\n" +
    $"║  - Magic Attack Bonus:  +{this.magicAttackBonus}                      ║\n" +
    $"║  - Magic Damage Bonus:  +{this.magicDamageBonus}                      ║\n" +
    "╠═════════════════════════════════════════════════╣\n" +
    "║                  Equipped Items                 ║\n" +
    $"║           {equippedDisplay}                                      ║ \n" +
    "╠═════════════════════════════════════════════════╣\n" +
    "║                  Inventory                      ║\n" +
    $"║           {inventoryDisplay}                                      ║ \n" +
    "╠═════════════════════════════════════════════════╣\n"


;
            Console.WriteLine(characterSheet);
        }
    }
}