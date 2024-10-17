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

        public HalfElf(){

            BonusAtributes.Add("Charisma", 2);
            // TODO adicionar +1 a outros dois atributos distintos

            DarkVision = true;

            Imunities.Add(IMUsleep);

            Advantages.Add(ADVfeyancestry);

            Languages.Add("Common");
            Languages.Add("Elvish");
            // TODO adicionar uma outra linguagem qualquer Languages.Add("Common");
            
        
        }
    }
}