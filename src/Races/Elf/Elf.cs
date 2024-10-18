using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ded4newba.src.Habilities;
using ded4newba.Src.PassiveHabilities;
using ded4newba.Src.Races;

namespace ded4newba.src.Races.Elf
{
    public class Elf : Race
    {
        readonly Advantage ADVfeyancestry = new(
            "Fey Ancestry",
            "Wisdom",
            "Charmed",
            "You have advantage on saving throws against being "+
            "charmed, and magic can't put you to sleep."
        );

        readonly Imunity IMUsleep = new(
            "Fey Ancestry",
            "Sleep",
            "You have advantage on saving throws against being "+
            "charmed, and magic can't put you to sleep."
        );

        readonly PassiveHability trance = new(
            "Tool Proficiency",
            "Elves don't need to sleep. Instead, they meditate deeply, remaining "+
            "semiconscious, for 4 hours a day. (The Common word for such meditati"+
            "on is “trance.”) While meditating, you can dream after a fashion; su"+
            "ch dreams are actually mental exercises that have become reflexive t"+
            "hrough years of practice. After resting in this way, you gain the sa"+
            "me benefit that a human does from 8 hours of sleep."
        );
        readonly Skill Perception = new(
            "Perception",
            "Wisdom",
            true,
            false
        );


        public Elf(){
            
            BonusAtributes.Add("Dexterity", 2);

            Movement = 30;

            DarkVision = true;

            Languages.Add("Common");
            Languages.Add("Elvish");

            PassiveHabilities.Add(trance);

            Advantages.Add(ADVfeyancestry, "Charmed");

            KnownSkills.Add(Perception);
        
            Imunities.Add(IMUsleep);
        }        
    }
}