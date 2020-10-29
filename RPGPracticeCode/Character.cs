using System;

namespace RPGPracticeCode
{
    class Character
    {
    
    public string name; //name of player or mob
    public string race; //such as human, elf, ogre, troll etc
    public int level;   //level of human or mob
    public int hitPoints; //how much hp character has  
    public int armourClass; //provides ac when attacked 
    public string size; //size of character if environment needs to know
    public string language; //language spoken by Character
    public int movementSpeed; //how fast a character moves. 
    public int strength; //strength = base attack bonus, also required for some skill checks
    public int intelligence; //provides intelligence modifier for skill checks
    public int charisma; //provides charisma modifier for skill checks
    public int constitution; //provides constitution modifier for hitpoints and saves
    public int wisdom; //provides wisom modifier for skill checks and saves 
 
  



    
        public string TargetToAttack()
        {
            //Targets character
            
        }
        public string TargetToHeal()
        {
            //If there is more than one player, and one has heal spells/items
        }
        public int TakeDamage(int)
        {
            //Taking Damage from Enemy
        }

        public int DoDamage(int)
        {
            //Doing damage to Enemy
        }

        public int ReceiveHealing(int)
        {
            //Restore no. of HP
        }

        public int AbilityModifier(int)
        {
            //Adds modifier to abilities
        }

        public string ChangeSize()
        {
            //Changes size and corrosponding modifiers
        }

        public bool Flee()
        {
            //does the character want to  flee? Is the mob low enough hitpoints to flee?
        }

        public bool LifeStatus()
        {
            //Alive or Dead
        }

        public Character (string name, string race, int level, int hitPoints, int armourClass, string size, string language, int movementSpeed, int strength, int intelligence, int charisma, int constitution, int wisdom)
        {
                this.name = name;
                this.race = race;
                this.level = level;
                this.hitPoints = hitPoints;
                this.armourClass = armourClass;
                this.size = size;
                this.language = language;
                this.movementSpeed = movementSpeed;
                this.strength = strength;
                this.intelligence = intelligence;
                this.charisma = charisma;
                this.constitution = constitution;
                this.wisdom = wisdom;

        }


    
    }

}