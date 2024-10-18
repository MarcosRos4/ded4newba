using ded4newba.Src.PassiveHabilities;
using ded4newba.Src.Backgrounds;
using ded4newba.src.Habilities;

namespace ded4newba.src.Backgrounds
{
    public class Acolyte : Background
    {

        readonly PassiveHability proficiency = new(
            "Shelter of the Faithful",// name
            // description
            "As an acolyte, you command the respect of those who share your faith," +
            " and you can perform the religious ceremonies of your deity. "+
            "You and your adventuring companions can expect to receive free healing and care at a temple, shrine,"+
            " or other established presence of your faith, though you must provide any material components needed for spells."+
            " Those who share your religion will support you (but only you) at a modest lifestyle. \n"+
            "You might also have ties to a specific temple dedicated to your chosen deity or pantheon,"+
            " and you have a residence there. This could be the temple where you used to serve,"+
            " if you remain on good terms with it, or a temple where you have found a new home. While near your temple,"+
            " you can call upon the priests for assistance, provided the assistance you ask for is not hazardous"+
            " and you remain in good standing with your temple.");

        readonly Skill insight = new(
            "Insight",
            "Wisdom",
            true,
            false
        );

        readonly Skill religion = new(
            "Religion",
            "Intelligence",
            true,
            false
        );
        public Acolyte(string language1, string language2){
            
            KnownSkills.Add(insight);
            KnownSkills.Add(religion);
            
            Languages.Add(language1);
            Languages.Add(language2);
            
            PassiveHabilities.Add(proficiency.Name, proficiency.Description);
            
        }
    }
}