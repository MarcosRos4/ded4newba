using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ded4newba.src.Proficiencies;
using ded4newba.Src.Backgrounds;

namespace ded4newba.src.Backgrounds
{
    public class Outlander : Background
    {
        readonly private Proficiency musicalinstrument = new(
            "Musical Instrument",
            "If you have proficiency with a given musical instrument, you can add your pr"+
            "oficiency bonus to any ability checks you make to play music with the instru"+
            "ment. A bard can use bagpipes as a spellcasting focus."
        );
        
        readonly private Proficiency wanderer = new(
            "Wanderer",
            "You have an excellent memory for maps and geography, and you can always rec"+
            "all the general layout of terrain, settlements, or other features around yo"+
            "u. Additionally, you can find food and fresh water for yourself and up to f"+
            "ive other people each day, provided that the land offers berries, small fru"+
            "its, water, and the like."
        );

        public Outlander(){
            Skills = ["Survival", "Athletics"];
            Languages = ["Abissal"];
            Proficiencies.Add(musicalinstrument);
            Proficiencies.Add(wanderer);
        }

    }
}