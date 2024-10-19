using ded4newba.Src.Backgrounds;

namespace ded4newba.src.Backgrounds.FolkHero
{
    public class FolkHero : Background
    {
        public FolkHero(){
            
            KnownSkills.AddRange([
                new(
                "Artisan's Tools",
                "Dexterity",
                true,
                false
                ),
                new(
                "Controll Land Vehicle",
                "Dexterity",
                true,
                false
                ),
                new(
                "Survival",
                "Wisdom",
                true,
                false
                ),
                new(
                "Animal Handling",
                "Wisdom",
                true,
                false
                )
            ]);
            
            PassiveHabilities.Add(new(
            "Rustic Hospitality",
            "Since you come from the ranks of the common folk, you fit in among them w"+
            "ith ease. You can find a place to hide, rest, or recuperate among other c"+
            "ommoners, unless you have shown yourself to be a danger to them. They wil"+
            "l shield you from the law or anyone else searching for you, though they w"+
            "ill not risk their lives for you."
            ));           
        }
    }
}