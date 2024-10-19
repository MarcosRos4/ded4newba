using ded4newba.Src.Backgrounds;

namespace ded4newba.src.Backgrounds
{
    public class Soldier : Background
    {

        public Soldier(){
            
            KnownSkills.AddRange([
                new(
                    "Control Land Vehicle",
                    "Dexterity",
                    true,
                    false
                ),
                new(
                    "Intimidation",
                    "Charisma",
                    true,
                    false
                ),
                new(
                    "Athletics",
                    "Strength",
                    true,
                    false
                )
            ]);
            
            PassiveHabilities.Add(new(
                "Military Rank",
                "You have a military rank from your career as a soldier. Soldiers loyal t"+
                "o your former military organization still recognize your authority and i"+
                "nfluence, and they defer to you if they are of a lower rank. You can inv"+
                "oke your rank to exert influence over other soldiers and requisition sim"+
                "ple equipment or horses for temporary use. You can also usually gain acc"+
                "ess to friendly military encampments and fortresses where your rank is r"+
                "ecognized."
            ));
        }
    }
}