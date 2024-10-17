using ded4newba.src.Habilities;
using ded4newba.Src.Races;

namespace ded4newba.src.Races.Tiefling
{
    public class Tiefling : Race
    {
        //TODO infernal legacy magias

        readonly Resistance resistance = new(
            "Hellish Resistance",
            "Fire",
            "You have resistance to fire damage."
        );

        public Tiefling(){

            BonusAtributes.Add("Charisma", 2);
            BonusAtributes.Add("Intelligence", 1);
            
            DarkVision = true;

            Resistances.Add(resistance);

            Languages.Add("Common");
            Languages.Add("Infernal");
        }
    }
}