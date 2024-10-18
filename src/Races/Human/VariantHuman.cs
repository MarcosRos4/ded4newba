using ded4newba.Src.Races;
using ded4newba.src.Habilities;

namespace ded4newba.src.Races.Human
{
    public class VariantHuman : Race
    {
        public VariantHuman(string atribute1, string atribute2, string language, Skill skill ,string feat){
            BonusAtributes.Add(atribute1, 1); 
            BonusAtributes.Add(atribute2, 1);


            Movement = 30;

            Languages.Add("Common");
            Languages.Add(language); 

            KnownSkills.Add(skill); 

            // TODO adicionar um talento para ser proeficiente
        }
    }
}