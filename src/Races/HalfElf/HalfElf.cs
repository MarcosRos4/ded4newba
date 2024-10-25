using ded4newba.src.Habilities;
using ded4newba.Src.Races;

namespace ded4newba.src.Races.HalfElf
{
    public class HalfElf : Race
    {
        public HalfElf(string language, string atribute1, string atribute2){

            BonusAtributes.Add("Charisma", 2);
            BonusAtributes.Add(atribute1, 1);
            BonusAtributes.Add(atribute2, 1);

            DarkVision = true;

            Imunities.Add(new(
            "Fey Ancestry",
            "Sleep",
            "You have advantage on saving throws against being "+
            "charmed, and magic can't put you to sleep."
            ));

            Advantages.Add(new(
            "Fey Ancestry",
            "Wisdom",
            "Charmed",
            "You have advantage on saving throws against being "+
            "charmed, and magic can't put you to sleep."
            ));

            Languages.Add("Common");
            Languages.Add("Elvish");
            Languages.Add(language);           
        
        }
    }
}