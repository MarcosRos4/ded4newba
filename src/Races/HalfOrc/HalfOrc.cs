using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ded4newba.Src.PassiveHabilities;
using ded4newba.Src.Races;

namespace ded4newba.src.Races.HalfOrc
{
    public class HalfOrc : Race
    {
        readonly PassiveHability relentlessendurance = new(
            "Relentless Endurance",
            "When you are reduced to 0 hit points but not killed"+
            " outright, you can drop to 1 hit point instead. You"+
            " can't use this feature again until you finish a lo"+
            "ng rest"
        );

        // TODO savage attacks tratar como talento

        public HalfOrc(){

            BonusAtributes.Add("Strength", 2);
            BonusAtributes.Add("Constitution", 1);
            
            DarkVision = true;

            Languages.Add("Common");
            Languages.Add("Orc");

            Skills.Add("Intimidation");
        }
    }
}