using ded4newba.Src.Habilities;

namespace ded4newba.src.Races.Gnome
{
    public class ForestGnome : Gnome
    {
        // TODO Natural Illusionist. You know the minor illusion cantrip. Intelligence is your spellcasting ability for it.

        public ForestGnome(){
            
            BonusAtributes.Add("Dexterity", 1);

            PassiveHabilities.Add(new(
            "Speak with small beasts",
            "Through sounds and gestures, you can communicate simple ideas with "+
            "Small or smaller beasts. Forest gnomes love animals and often keep "+
            "squirrels, badgers, rabbits, moles, woodpeckers, and other creatures as beloved pets."
        ));
        }
    }
}