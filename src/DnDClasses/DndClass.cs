using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ded4newba.Src.DnDClasses
{
    public class DndClass
    {
        public int LifeDice { get; set; }

        public int ClassLevel { get; set; }

        public  List<string> SavingThrows {get; set;}
    }
}