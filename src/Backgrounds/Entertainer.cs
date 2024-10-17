using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ded4newba.src.Proficiencies;
using ded4newba.Src.Backgrounds;

namespace ded4newba.src.Backgrounds
{
    public class Entertainer : Background
    {
        readonly private Proficiency disguisekit = new(
            "Disguise Kit",
            "This pouch of cosmetics, hair dye, and small props lets you create disguises"+
            " that change your physical appearance. Proficiency with this kit lets you ad"+
            "d your proficiency bonus to any ability checks you make to create a visual d"+
            "isguise."
        );

        readonly private Proficiency musicalinstrument = new(
            "Musical Instrument",
            "If you have proficiency with a given musical instrument, you can add your pr"+
            "oficiency bonus to any ability checks you make to play music with the instru"+
            "ment. A bard can use bagpipes as a spellcasting focus."
        );

        readonly private Proficiency bypopulardemand = new(
            "By Popular Demand",
            "You always find a place to perform, usually in taverns or inns, but possibl"+
            "y in circuses, theaters, or even noble courts. In such places, you receive "+
            "lodging and modest or comfortable food for free (depending on the quality o"+
            "f the establishment) as long as you perform each night. Additionally, your "+
            "performance makes you a kind of local figure. When strangers recognize you "+
            "in a city where you have performed, they generally like you."
        );

        public Entertainer(){
            Skills = ["Acrobatics", "Performance"];
            Languages = [];
            Proficiencies.Add(disguisekit);
            Proficiencies.Add(musicalinstrument);
            Proficiencies.Add(bypopulardemand);
        }

    }
}