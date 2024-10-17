using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ded4newba.Src.PassiveHabilities;

namespace ded4newba.src.Races.Gnome
{
    public class ForestGnome : Gnome
    {
        // TODO Natural Illusionist. You know the minor illusion cantrip. Intelligence is your spellcasting ability for it.

        readonly PassiveHability passiveHability = new(
            "Speak with small beasts",
            "Through sounds and gestures, you can communicate simple ideas with "+
            "Small or smaller beasts. Forest gnomes love animals and often keep "+
            "squirrels, badgers, rabbits, moles, woodpeckers, and other creatures as beloved pets."
        );

        public ForestGnome(){
            
            BonusAtributes.Add("Dexterity", 1);

            PassiveHabilities.Add(passiveHability);
        }
    }
}