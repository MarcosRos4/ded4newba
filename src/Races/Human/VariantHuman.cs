using ded4newba.Src.Races;

namespace ded4newba.src.Races.Human
{
    public class VariantHuman : Race
    {
        public VariantHuman(){
            BonusAtributes.Add("Strength", 1); //TODO poder escolher 2 quaisquer atributos para adicionar em 1 cada
            BonusAtributes.Add("Constitution", 1);


            Movement = 30;

            Languages.Add("Common");
            Languages.Add("Dwarvish"); // TODO escolher mais uma linguagem qualquer

            KnownSkills.Add("Percepction"); // TODO escolher uma pericia para ser proeficiente

            // TODO adicionar um talento para ter proeficiencia
        }
    }
}