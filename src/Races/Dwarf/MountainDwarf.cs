using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ded4newba.src.Habilities;
using ded4newba.Src.PassiveHabilities;
using ded4newba.Src.Races;

namespace ded4newba.src.Races.Dwarf
{
    public class MountainDwarf : Dwarf
    {


        // Dwarven Armor Training. You have proficiency with light and medium armor.
        // adicionar o tipo de proeficiencia de itens

        public MountainDwarf(){
            
            BonusAtributes.Add("Strength", 2);

        }             
    }
}