using ded4newba.Src.PassiveHabilities;
using ded4newba.Src.Backgrounds;

namespace ded4newba.src.Backgrounds
{
    public class FolkHero : Background
    {
        readonly PassiveHability rustichospitality = new(
            "Rustic Hospitality",
            "Since you come from the ranks of the common folk, you fit in among them w"+
            "ith ease. You can find a place to hide, rest, or recuperate among other c"+
            "ommoners, unless you have shown yourself to be a danger to them. They wil"+
            "l shield you from the law or anyone else searching for you, though they w"+
            "ill not risk their lives for you."
        );
        
        public FolkHero(){
            
            KnownSkills.Add("Animal Handling");
            KnownSkills.Add("Survival");
            KnownSkills.Add("Controll Land Vehicle");
            KnownSkills.Add("Artisan's Tools");
            
            PassiveHabilities.Add(rustichospitality.Name, rustichospitality.Description);
            
        }
    }
}