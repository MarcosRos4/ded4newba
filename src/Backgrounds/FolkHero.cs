using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ded4newba.src.Proficiencies;
using ded4newba.Src.Backgrounds;

namespace ded4newba.src.Backgrounds
{
    public class FolkHero : Background
    {
        readonly Proficiency vehicle = new(
            "Land Vehicle",
            "You add tour proficiency bonus to any checks to control any land vehicle."
        );
        readonly Proficiency artisanstools = new(
            "Artisan's Tools", // fazer feature de escolher qual tipo de ferramenta de artesão
            "These special tools include the items needed to pursue a craft or trade."+
            " Proficiency with a set of artisan's tools lets you add your proficiency"+
            " bonus to any ability checks you make using the tools in your craft. Each"+
            " type of artisan's tools requires a separate proficiency."
        );

        readonly Proficiency rustichospitality = new(
            "Rustic Hospitality",
            "Since you come from the ranks of the common folk, you fit in among them w"+
            "ith ease. You can find a place to hide, rest, or recuperate among other c"+
            "ommoners, unless you have shown yourself to be a danger to them. They wil"+
            "l shield you from the law or anyone else searching for you, though they w"+
            "ill not risk their lives for you."
        );
        
        public FolkHero(){
            Skills = ["Animal Handling", "Survival"];
            Languages = [];
            Proficiencies.Add(vehicle);
            Proficiencies.Add(artisanstools);
            Proficiencies.Add(rustichospitality);
        }
    }
}