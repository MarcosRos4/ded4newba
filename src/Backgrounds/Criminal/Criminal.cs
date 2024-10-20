using ded4newba.Src.Backgrounds;

namespace ded4newba.src.Backgrounds.Criminal
{
    public class Criminal : Background
    {
        public Criminal(){
            
            KnownSkills.AddRange([
                new(
                    "Deception",
                    "Charisma",
                    true,
                    false
                ),
                new(
                    "Stealth",
                    "Dexterity",
                    true,
                    false
                ),
                new(
                    "Disarm Trap",
                    "Dexterity",
                    true,
                    false
                ),
                new(
                    "Open Lock",
                    "Dexterity",
                    true,
                    false
                )
            ]);
            
            PassiveHabilities.AddRange([
                new(
                    "Thieves' Tools",
                    "This set of tools includes a small file, a set of lock picks, a small mirror mounted on a metal handle,"+
                    " a set of narrow-bladed scissors, and a pair of pliers. Proficiency with these tools lets you add your "+
                    "proficiency bonus to any ability checks you make to disarm traps or open locks."
                ),
                new(
                    "Criminal Contact",
                    "You have a reliable and trustworthy contact who acts as your liaison to a network of other criminals."+
                    " You know how to get messages to and from your contact, even over great distances; specifically,"+
                    " you know the local messengers, corrupt caravan masters, and seedy sailors who can deliver messages for you."
                )
            ]);
        }
    }
}