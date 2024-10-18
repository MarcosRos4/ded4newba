using ded4newba.Src.PassiveHabilities;
using ded4newba.Src.Backgrounds;
using ded4newba.src.Habilities;

namespace ded4newba.src.Backgrounds
{
    public class Outlander : Background
    {
        readonly private PassiveHability musicalinstrument = new(
            "Musical Instrument",
            "If you have proficiency with a given musical instrument, you can add your pr"+
            "oficiency bonus to any ability checks you make to play music with the instru"+
            "ment. A bard can use bagpipes as a spellcasting focus."
        );
        
        readonly private PassiveHability wanderer = new(
            "Wanderer",
            "You have an excellent memory for maps and geography, and you can always rec"+
            "all the general layout of terrain, settlements, or other features around yo"+
            "u. Additionally, you can find food and fresh water for yourself and up to f"+
            "ive other people each day, provided that the land offers berries, small fru"+
            "its, water, and the like."
        );
        readonly Skill Survival = new(
            "Survival",
            "Wisdom",
            true,
            false
        );
        readonly Skill Athletics = new(
            "Athletics",
            "Strength",
            true,
            false
        );
        readonly Skill Performance = new(
            "Performance",
            "Charisma",
            true,
            false
        );

        public Outlander(string language){
            
            KnownSkills.Add(Survival);
            KnownSkills.Add(Athletics);
            KnownSkills.Add(Performance);
            
            Languages.Add(language);
            
            PassiveHabilities.Add(musicalinstrument.Name, musicalinstrument.Description);
            PassiveHabilities.Add(wanderer.Name, musicalinstrument.Description);
        }

    }
}