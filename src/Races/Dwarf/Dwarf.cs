using ded4newba.src.Habilities;
using ded4newba.Src.Habilities;
using ded4newba.Src.Races;

namespace ded4newba.src.Races.Dwarf
{
    public class Dwarf : Race
    {
        readonly Advantage ADVdwarvenresilience = new(
            "Dwarven Resilience",
            "Constitution",
            "Poisoned",
            "You have advantage on saving throws against poison,"+
            " and you have resistance against poison damage."
        );

        readonly PassiveHability dwarvenresilience = new(
            "Dwarven Resilience",
            "You have advantage on saving throws against poison,"+
            " and you have resistance against poison damage."
        );

        readonly PassiveHability toolproficiency = new(
            "Tool Proficiency",
            "You gain proficiency with the artisan's tools of y"+
            "our choice: smith's tools, brewer's supplies, or mason's tools."
        );

        readonly PassiveHability stonecunning = new(
            "Stonecunning",
            "Whenever you make an Intelligence (History) check"+
            " related to the origin of stonework, you are cons"+
            "idered proficient in the History skill and add do"+
            "uble your proficiency bonus to the check, instead"+
            " of your normal proficiency bonus."
        );

        readonly Skill ArtisanTools = new(
            "Artisan's Tools",
            "Dexterity",
            true,
            false
        );
        readonly Skill Stonecunning = new(
            "Stonecunning",
            "Intelligence",
            true,
            true
        );
        

        public Dwarf(){
            BonusAtributes.Add("Constitution", 2);

            Movement = 30;

            DarkVision = true;

            Languages.Add("Common");
            Languages.Add("Dwarvish");

            PassiveHabilities.Add(toolproficiency);
            PassiveHabilities.Add(stonecunning);
            PassiveHabilities.Add(dwarvenresilience);

            Advantages.Add(ADVdwarvenresilience);

            Resistances.Add("Poison");

            KnownSkills.Add(ArtisanTools);
            KnownSkills.Add(Stonecunning);
        }
    }
}