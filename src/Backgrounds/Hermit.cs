using ded4newba.src.Proficiencies;
using ded4newba.Src.Backgrounds;

namespace ded4newba.src.Backgrounds
{
    public class Hermit : Background
    {
        readonly private Proficiency herbalismkit = new(
            "Herbalism Kit",
            "This kit contains a variety of instruments such as clippers, mortar and pestle,"+
            " and pouches and vials used by herbalists to create remedies and potions. Profi"+
            "ciency with this kit lets you add your proficiency bonus to any ability checks "+
            "you make to identify or apply herbs. Also, proficiency with this kit is require"+
            "d to create antitoxin and any potion of healing."
        );
        readonly private Proficiency discovery = new(
            "Discobery",
            "The quiet seclusion of your extended hermitage gave you access to unique and po"+
            "werful discoveries. The exact nature of these revelations depends on the nature"+
            " of your seclusion. It could be a great truth about the cosmos, the gods, the p"+
            "owerful beings of other planes, or the forces of nature. It might be a site tha"+
            "t no one else has ever seen. You may have unearthed a long-forgotten fact or di"+
            "scovered a relic from the past that could rewrite history. It could be informat"+
            "ion detrimental to those responsible for your exile, hence the reason you retur"+
            "ned to society. Discuss with the Dungeon Master to determine the details of you"+
            "r discovery and its impact on the campaign."
        );
        
        
        public Hermit(){
            Skills = ["Medicine", "Religion"];
            Languages = ["Infernal"];
            Proficiencies.Add(discovery);
            Proficiencies.Add(herbalismkit);
        }
    }
}