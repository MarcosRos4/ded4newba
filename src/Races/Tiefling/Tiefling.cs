using ded4newba.src.Habilities;
using ded4newba.Src.PassiveHabilities;
using ded4newba.Src.Races;

namespace ded4newba.src.Races.Tiefling
{
    public class Tiefling : Race
    {
        //TODO infernal legacy magias

        readonly PassiveHability resistance = new(
            "Hellish Resistance",
            
            "You have resistance to fire damage."
        );

        public Tiefling(){

            BonusAtributes.Add("Charisma", 2);
            BonusAtributes.Add("Intelligence", 1);
            
            DarkVision = true;

            PassiveHabilities.Add(resistance);

            Resistances.Add("Fire");

            Languages.Add("Common");
            Languages.Add("Infernal");
        }
    }
}