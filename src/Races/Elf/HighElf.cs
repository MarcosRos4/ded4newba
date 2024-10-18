namespace ded4newba.src.Races.Elf
{
    public class HighElf : Elf
    {

        public HighElf(string language){
            
            BonusAtributes.Add("Intelligence", 1);

            Languages.Add(language); // TODO escolher qual idioma

            // proeficiencia de item
            // Elf Weapon Training. You have proficiency with 
            // the longsword, shortsword, shortbow, and longbow.

            // magia
            // Cantrip. You know one cantrip of your choice from 
            // the wizard spell list. Intelligence is your spellcasting 
            // ability for it.
        }
    }
}