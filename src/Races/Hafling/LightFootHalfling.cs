using ded4newba.Src.PassiveHabilities;

namespace ded4newba.src.Races.Hafling
{
    public class LightFootHalfling : Halfling
    {
        readonly PassiveHability PSnaturallystealthy = new(
            "Naturally Stealthy",
            "You can attempt to hide even when you are obscured only by a "+
            "creature that is at least one size larger than you."
        );

        public LightFootHalfling(){

            BonusAtributes.Add("Charisma", 1);

            PassiveHabilities.Add(PSnaturallystealthy);
        }
    }
}