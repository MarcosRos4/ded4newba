namespace ded4newba.src.Habilities.Feats
{
    public class Tough : Feat
    {
        public Tough(){

            PassiveHability = new(
                "Tough",
                "Your hit point maximum increases by an amount equal "+
                "to twice your level when you gain this feat. Whenever you gain a "+
                "level thereafter, your hit point maximum increases by an additional 2 hit points"
            );            

        }
    }
}