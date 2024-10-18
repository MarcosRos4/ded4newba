using ded4newba.Src.PassiveHabilities;
using ded4newba.Src.Backgrounds;
using ded4newba.src.Habilities;

namespace ded4newba.src.Backgrounds
{
    public class Criminal : Background
    {
        readonly private PassiveHability thievestools = new(
            "Thieves' Tools",
            "This set of tools includes a small file, a set of lock picks, a small mirror mounted on a metal handle,"+
            " a set of narrow-bladed scissors, and a pair of pliers. Proficiency with these tools lets you add your "+
            "proficiency bonus to any ability checks you make to disarm traps or open locks.");

        readonly private PassiveHability criminalcontact = new(
            "Criminal Contact",
            "You have a reliable and trustworthy contact who acts as your liaison to a network of other criminals."+
            " You know how to get messages to and from your contact, even over great distances; specifically,"+
            " you know the local messengers, corrupt caravan masters, and seedy sailors who can deliver messages for you."
        );

        readonly Skill Deception = new(
            "Deception",
            "Charisma",
            true,
            false
        );
        readonly Skill OpenLock = new(
            "Open Lock",
            "Dexterity",
            true,
            false
        );
        readonly Skill DisarmTrap = new(
            "Disarm Trap",
            "Dexterity",
            true,
            false
        );
        readonly Skill Stealth = new(
            "Stealth",
            "Dexterity",
            true,
            false
        );

        public Criminal(){
            
            KnownSkills.Add(Deception);
            KnownSkills.Add(Stealth);
            KnownSkills.Add(DisarmTrap);
            KnownSkills.Add(OpenLock);
            
            PassiveHabilities.Add(thievestools.Name, thievestools.Description);
            PassiveHabilities.Add(criminalcontact.Name, criminalcontact.Description);
        }
    }
}