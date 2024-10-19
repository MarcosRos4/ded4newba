namespace ded4newba.src.Habilities.Feats
{
    public class KeenMind : Feat
    {
        public KeenMind(){
            
            AttributeBonus.Attribute = "Intelligence";
            AttributeBonus.Number = 1;
            
            PassiveHability = new(
                "Keen Mind",
                "You always know which way is north. You always know the"+
                " number of hours left before the next sunrise or sunset. You can a"+
                "ccurately recall anything you have seen or heard within the past month."
            );
        }
    }
}