using ded4newba.src.Habilities;
using ded4newba.Src.PassiveHabilities;
using ded4newba.Src.Races;

namespace ded4newba.src.Races.Hafling
{
    public class Halfling : Race
    {
        // talento de sorte 
        /*
            Lucky. When you roll a 1 on an attack roll, ability 
            check, or saving throw, you can reroll the die and must 
            use the new roll.
        */         

        readonly Advantage ADVbrave = new(
            "Brave",
            "Wisdom",
            "Frightened",
            "You have advantage on saving throws against being frightened."
        );

        readonly PassiveHability PShalfingnimbleness = new(
            "Halfling Nimbleness",
            "You can move through the space of any creature that is of a size larger than yours."
        );

        public Halfling(){

            BonusAtributes.Add("Dexterity", 2);

            Movement = 25;

            Advantages.Add(ADVbrave, "Frightened");

            PassiveHabilities.Add(PShalfingnimbleness);

            Languages.Add("Common");
            Languages.Add("Halfling");
        }

    }
}