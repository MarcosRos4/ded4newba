namespace ded4newba.src.Habilities.Feats
{
    public class Actor : Feat
    {
        public Actor(){
            AttributeBonus.Attribute = "Charisma";
            AttributeBonus.Number = 1;

            Advantages.Add(new Advantage("","","",""), "Deception");
            Advantages.Add(new Advantage("","","",""), "Performance");

            PassiveHability = new(
                "Actor",
                "You can mimic the speech of another person or the sounds made by other creatures. You"+
                " must have heard the person speaking, or heard the creature make the sound, for at least 1 minute."+
                " A successful Wisdom (Insight) check contested by your Charisma (Deception) check allows a listene"+
                "r to determine that the effect is faked."
            );
        }
    }
}