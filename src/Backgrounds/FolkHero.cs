using ded4newba.Src.PassiveHabilities;
using ded4newba.Src.Backgrounds;

namespace ded4newba.src.Backgrounds
{
    public class FolkHero : Background
    {
        readonly PassiveHability vehicle = new(
            "Land Vehicle",
            "You add tour proficiency bonus to any checks to control any land vehicle."
        );
        readonly PassiveHability artisanstools = new(
            "Artisan's Tools", // fazer feature de escolher qual tipo de ferramenta de artesão
            "These special tools include the items needed to pursue a craft or trade."+
            " Proficiency with a set of artisan's tools lets you add your proficiency"+
            " bonus to any ability checks you make using the tools in your craft. Each"+
            " type of artisan's tools requires a separate proficiency."
        );

        readonly PassiveHability rustichospitality = new(
            "Rustic Hospitality",
            "Since you come from the ranks of the common folk, you fit in among them w"+
            "ith ease. You can find a place to hide, rest, or recuperate among other c"+
            "ommoners, unless you have shown yourself to be a danger to them. They wil"+
            "l shield you from the law or anyone else searching for you, though they w"+
            "ill not risk their lives for you."
        );
        
        public FolkHero(){
            Skills = ["Animal Handling", "Survival", "Controll Land Vehicle", "Artisan's Tools"];
            Languages = [];

            PassiveHabilities.Add(rustichospitality.Name, rustichospitality.Description);
            
        }
    }
}