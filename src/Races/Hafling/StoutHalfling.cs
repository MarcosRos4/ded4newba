using ded4newba.src.Habilities;
using ded4newba.Src.Habilities;

namespace ded4newba.src.Races.Hafling
{
    public class StoutHalfling : Halfling
    {
        readonly PassiveHability resistance = new(
            "Stout Resistance",
            "You have advantage on saving throws against poison, and you have resistance against poison damage."
        );

        readonly Advantage advantage = new(
            "Stout Resistance",
            "Constitution",
            "Poisoned",
            "You have advantage on saving throws against poison, and you have resistance against poison damage."
        );

        public StoutHalfling(){

            BonusAtributes.Add("Constitution", 1);

            Advantages.Add(advantage, "Poisoned");

            PassiveHabilities.Add(resistance);

            Resistances.Add("Poison");
        }
    }
}