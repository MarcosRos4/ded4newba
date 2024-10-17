using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ded4newba.src.Proficiencies;
using ded4newba.Src.Backgrounds;

namespace ded4newba.src.Backgrounds
{
    public class Noble : Background 
    {
        readonly private Proficiency positionofprivilege = new(
            "Position of Privilege",
            "Thanks to your noble birth, people are inclined to think the best of you."+
            " You are welcome in high society, and people assume you have the right to"+
            " be wherever you are. The common folk make every effort to accommodate yo"+
            "u and avoid your displeasure, and other people of high birth treat you as"+
            " a member of the same social sphere. You can secure an audience with a lo"+
            "cal noble if you need to."
        );

        public Noble(){
            Skills = ["History", "Persuasion"];
            Languages = ["Elven"];
            Proficiencies.Add(positionofprivilege);
        }
    }
}