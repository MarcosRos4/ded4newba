using ded4newba.Src.Habilities;
using ded4newba.Src.Backgrounds;

namespace ded4newba.src.Backgrounds
{
    public class Sailor : Background
    {
        readonly private Hability navigatorstools = new(
            "Navigator's Tools",
            "If you have proficiency with a tool, add your Proficiency Bonus to any abili"+
            "ty check you make that uses the tool. If you have proficiency in a skill tha"+
            "t's used with that check, you have Advantage on the check too."
        );
        readonly private Hability shipticket = new(
            "Ship Ticket",
            "Whenever you need, you can secure free passage on a ship for yourself and y"+
            "our adventuring companions. You must travel on a ship you have worked on or"+
            " one with which you have good relations (perhaps one commanded by a former "+
            "crew member). Since it is a favor, you cannot request a schedule or route t"+
            "hat caters to all your needs. Your Dungeon Master determines how long it wi"+
            "ll take to get to your destination. In exchange for free passage, you and y"+
            "our companions are expected to assist the crew during the voyage."
        );
        public Sailor(){
            Skills = ["Athletics", "Perception", "Navigator's Tools", "Control Aquatic Vehicle"];
            Languages = [];
            Habilities.Add(navigatorstools.Name, navigatorstools.Description);
            Habilities.Add(shipticket.Name, shipticket.Description);
        }
    }
}