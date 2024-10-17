namespace ded4newba.src.Races.Dwarf
{
    public class HillDwarf : Dwarf
    {
        

        // Dwarven Toughness adiciona 1 ponto de vida a mais todo level up

        public HillDwarf(){

            BonusAtributes.Add("Wisdom", 1);
       
        }        
    }
}