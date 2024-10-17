using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ded4newba.src.Habilities;
using ded4newba.Src.PassiveHabilities;

namespace ded4newba.src.Races.Elf
{
    public class Drow : Elf
    {
        readonly PassiveHability superiordarkvision = new(
            "Superior DarkVision",
            "Your darkvision has a radius of 120 feet."
        );

        /*
        Drow Magic.
            You know the dancing lights cantrip. 
            When you reach 3rd level, you can cast the faerie fire 
            spell once per day. When you reach 5th level, you can 
            also cast the darkness spell once per day. Charisma is 
            your spellcasting ability for these spells.

        Drow Weapon Training.
            You have proficiency with 
            rapiers, shortswords, and hand crossbows.
        */ 

        readonly DisAdvantage DISsunlightsensitivity = new(
            "Sunlight Disavantage",
            "Wisdom",
            "Perception",
            "You have disadvantage on attack rolls and on Wisdom (Perception) checks"+
            " that rely on sight when you, the target of your attack, or whatever yo"+
            "u are trying to perceive is in direct sunlight."
        );

        public Drow(){
            BonusAtributes.Add("Charisma", 1);

            PassiveHabilities.Add(superiordarkvision);

            DisAdvantages.Add(DISsunlightsensitivity);
        }
    }
}