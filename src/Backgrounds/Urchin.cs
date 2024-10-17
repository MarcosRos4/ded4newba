using ded4newba.src.Proficiencies;
using ded4newba.Src.Backgrounds;

namespace ded4newba.src.Backgrounds
{
    public class Urchin : Background
    {
        readonly private Proficiency disguisekit = new(
            "Disguise Kit",
            "This pouch of cosmetics, hair dye, and small props lets you create disguises"+
            " that change your physical appearance. Proficiency with this kit lets you ad"+
            "d your proficiency bonus to any ability checks you make to create a visual d"+
            "isguise."
        );
        readonly private Proficiency thievestools = new(
            "Thieves' Tools",
            "This set of tools includes a small file, a set of lock picks, a small mirror mounted on a metal handle,"+
            " a set of narrow-bladed scissors, and a pair of pliers. Proficiency with these tools lets you add your "+
            "proficiency bonus to any ability checks you make to disarm traps or open locks."
        );
        readonly private Proficiency citysecrets = new(
            "City Secrets",
            "You know the secret patterns and flow of the cities and can find pathways th"+
            "rough the urban sprawl that others would miss. When you are not in combat, y"+
            "ou (and the companions you lead) can travel between any two locations in the"+
            " city at twice the normal speed."
        );
        
        public Urchin(){
            Skills = ["Stealth", "Prestidigitation"];
            Languages = [];
            Proficiencies.Add(disguisekit);
            Proficiencies.Add(thievestools);
            Proficiencies.Add(citysecrets);
        }

    }
}