
using ded4newba.Src.PassiveHabilities;
using ded4newba.Src.Backgrounds;

namespace ded4newba.src.Backgrounds
{
    public class Soldier : Background
    {
        readonly PassiveHability militaryrank = new(
            "Military Rank",
            "You have a military rank from your career as a soldier. Soldiers loyal t"+
            "o your former military organization still recognize your authority and i"+
            "nfluence, and they defer to you if they are of a lower rank. You can inv"+
            "oke your rank to exert influence over other soldiers and requisition sim"+
            "ple equipment or horses for temporary use. You can also usually gain acc"+
            "ess to friendly military encampments and fortresses where your rank is r"+
            "ecognized."
        );

        public Soldier(){
            
            KnownSkills.Add("Athletics");
            KnownSkills.Add("Intimidation");
            KnownSkills.Add("Control Land Vehicle");
            
            PassiveHabilities.Add(militaryrank.Name, militaryrank.Description);
        }
    }
}