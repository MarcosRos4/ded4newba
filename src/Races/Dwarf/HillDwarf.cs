namespace ded4newba.src.Races.Dwarf
{
    public class HillDwarf : Dwarf
    {
        public HillDwarf(){

            BonusAtributes.Add("Wisdom", 1);

            Feats.Add( "Dwarven Toughness",new()
            {
                PassiveHability = new
                (
                    "Dwarven Toughness",
                    "Your hit point maximum increases by 1, and it increases"+
                    " by 1 every time you gain a level."
                )
            });
       
        }        
    }
}