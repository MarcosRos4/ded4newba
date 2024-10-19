using ded4newba.Src.Backgrounds;

namespace ded4newba.src.Backgrounds.Sage
{
    public class Sage : Background
    {
        public Sage(string language1, string language2){
         
            KnownSkills.AddRange([
                new(
                    "Arcana",
                    "Intelligence",
                    true,
                    false
                ),
                new(
                    "History",
                    "Intelligence",
                    true,
                    false
                )
            ]);
            
            Languages.AddRange([language1, language2]);         

            PassiveHabilities.Add(new(
            "Researcher",
            "When you attempt to learn or recall a piece of lore, if you do not know that information,"+
            " you often know where and from whom you can obtain it. Usually, this information comes fr"+
            "om a library, scriptorium, university, or a sage or other learned person or creature. You"+
            "r DM might rule that the knowledge you seek is secreted away in an almost inaccessible pl"+
            "ace, or that it simply cannot be found. Unearthing the deepest secrets of the multiverse "+
            "can require an adventure or even a whole campaign."
            ));
        }
    }
}