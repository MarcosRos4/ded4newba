using ded4newba.Src.Backgrounds;

namespace ded4newba.src.Backgrounds.Noble
{
    public class Noble : Background 
    {
        public Noble(string language){
            
            KnownSkills.AddRange([
                new(
                    "History",
                    "Intelligence",
                    true,
                    false
                ),
                new(
                    "Persuasion",
                    "Charisma",
                    true,
                    false
                )
            ]);
            
            Languages.Add(language);
            
            PassiveHabilities.Add(new(
            "Position of Privilege",
            "Thanks to your noble birth, people are inclined to think the best of you."+
            " You are welcome in high society, and people assume you have the right to"+
            " be wherever you are. The common folk make every effort to accommodate yo"+
            "u and avoid your displeasure, and other people of high birth treat you as"+
            " a member of the same social sphere. You can secure an audience with a lo"+
            "cal noble if you need to."
            ));
        }
    }
}