using ded4newba.Src.PassiveHabilities;
using ded4newba.Src.Backgrounds;
using ded4newba.src.Habilities;

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
        readonly Skill AnimalHandling = new(
            "Animal Handling",
            "Wisdom",
            true,
            false
        );
        readonly Skill Survival = new(
            "Survival",
            "Wisdom",
            true,
            false
        );
        readonly Skill ControlLandVehicle = new(
            "Controll Land Vehicle",
            "Dexterity",
            true,
            false
        );
        readonly Skill ArtisansTools = new(
            "Artisan's Tools",
            "Dexterity",
            true,
            false
        );
        
        public FolkHero(){
            
            KnownSkills.Add(AnimalHandling);
            KnownSkills.Add(Survival);
            KnownSkills.Add(ControlLandVehicle);
            KnownSkills.Add(ArtisansTools);
            
            PassiveHabilities.Add(rustichospitality.Name, rustichospitality.Description);
            
        }
    }
}