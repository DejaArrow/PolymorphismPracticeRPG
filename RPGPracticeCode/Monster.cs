using System;

namespace RPGPracticeCode
{
    class Monster : Character
    {
        public string loot; //Money and items held by Monster that drop when monster dies
    }

    // if hp less than 4 but greater than 0 - flee
    //vso if monster has 6hp and is attacked for 3, the monster will flee. 
    // but if monster has 6hp and is attacked for 6, the monster dies. 
    // Perhaps not every monster will have flee option?
}