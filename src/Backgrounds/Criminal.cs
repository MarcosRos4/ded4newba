using ded4newba.src.Proficiencies;
using ded4newba.Src.Backgrounds;

namespace ded4newba.src.Backgrounds
{
    public class Criminal : Background
    {
        readonly private Proficiency thievestools = new(
            "Thieves' Tools",
            "This set of tools includes a small file, a set of lock picks, a small mirror mounted on a metal handle,"+
            " a set of narrow-bladed scissors, and a pair of pliers. Proficiency with these tools lets you add your "+
            "proficiency bonus to any ability checks you make to disarm traps or open locks.");

        readonly private Proficiency criminalcontact = new(
            "Criminal Contact",
            "You have a reliable and trustworthy contact who acts as your liaison to a network of other criminals."+
            " You know how to get messages to and from your contact, even over great distances; specifically,"+
            " you know the local messengers, corrupt caravan masters, and seedy sailors who can deliver messages for you."
        );
        public Criminal(){
            Skills = ["Deception", "Stealth"];
            Languages = [];
            Proficiencies.Add(thievestools);
            Proficiencies.Add(criminalcontact);
        }
    }
}