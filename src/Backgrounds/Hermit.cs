using ded4newba.Src.PassiveHabilities;
using ded4newba.Src.Backgrounds;
using ded4newba.src.Habilities;

namespace ded4newba.src.Backgrounds
{
    public class Hermit : Background
    {
        readonly private PassiveHability herbalismkit = new(
            "Herbalism Kit",
            "This kit contains a variety of instruments such as clippers, mortar and pestle,"+
            " and pouches and vials used by herbalists to create remedies and potions. Profi"+
            "ciency with this kit lets you add your proficiency bonus to any ability checks "+
            "you make to identify or apply herbs. Also, proficiency with this kit is require"+
            "d to create antitoxin and any potion of healing."
        );
        readonly private PassiveHability discovery = new(
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
        
        
        readonly Skill Medicine = new(
            "Medicine",
            "Wisdom",
            true,
            false
        );
        readonly Skill Religion = new(
            "Religion",
            "Intelligence",
            true,
            false
        );
        readonly Skill Nature = new(
            "Nature",
            "Intelligence",
            true,
            false
        );
        
        public Hermit(string language){
            
            KnownSkills.Add(Medicine);
            KnownSkills.Add(Religion);
            KnownSkills.Add(Nature);

            Languages.Add(language);
            
            PassiveHabilities.Add(discovery.Name, discovery.Description);
            PassiveHabilities.Add(herbalismkit.Name, herbalismkit.Description);
        }
    }
}