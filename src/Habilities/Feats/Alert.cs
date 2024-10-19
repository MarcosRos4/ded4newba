namespace ded4newba.src.Habilities.Feats
{
    public class Alert : Feat
    {
        public Alert(){
            Initiative = 5;
            // TODO adicionar imunidade a ser surpreso
            PassiveHability = new(
                "Alert",
                " Other creatures don't gain advantage on attack rolls "+
                "against you as a result of being hidden from you."
            );

            
        }
    }
}