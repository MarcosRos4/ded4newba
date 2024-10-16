using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ded4newba.Src.DnDClasses;

namespace ded4newba.src.DnDClasses
{
    public class Bard : DndClass
    {
        public Bard(){
            LifeDice = 8;
            ClassLevel = 1;
            SavingThrows = ["Wisdom", "Charisma"];
        }
    }
}