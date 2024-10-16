using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ded4newba.Src.Races;

namespace ded4newba.src.Races
{
    public class Gnome : Race
    {
        public Gnome(){
            Movement = 20;
            BonusAtributes = new Dictionary<string, int> {{"Dextress", 3}, {"Inteligence", 3}};
        }
    }
}