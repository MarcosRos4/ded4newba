using ded4newba.src.Habilities;
using ded4newba.Src.Races;

namespace ded4newba.src.Races.HalfElf
{
    public class HalfElf : Race
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

        public HalfElf(string language, string atribute1, string atribute2){

            BonusAtributes.Add("Charisma", 2);
            BonusAtributes.Add(atribute1, 1);
            BonusAtributes.Add(atribute2, 1);

            DarkVision = true;

            Imunities.Add(IMUsleep);

            Advantages.Add(ADVfeyancestry, "Charmed");

            Languages.Add("Common");
            Languages.Add("Elvish");
            Languages.Add(language);           
        
        }
    }
}