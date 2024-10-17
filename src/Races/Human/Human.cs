using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ded4newba.Src.Races;

namespace ded4newba.src.Races.Human
{
    public class Human : Race
    {
        public Human(){
            BonusAtributes.Add("Strength", 1);
            BonusAtributes.Add("Constitution", 1);
            BonusAtributes.Add("Dexterity", 1);
            BonusAtributes.Add("Intelligence", 1);
            BonusAtributes.Add("Wisdom", 1);
            BonusAtributes.Add("Charisma", 1);

            Movement = 30;

            Languages.Add("Common");
            Languages.Add("Dwarvish"); // TODO escolher mais uma linguagem qualquer
        }
    }
}