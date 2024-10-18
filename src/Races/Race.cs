using ded4newba.src.Habilities;
using ded4newba.Src.PassiveHabilities;

namespace ded4newba.Src.Races
{
    public class Race
    {
        public Dictionary<string, int> BonusAtributes = [];
        public int Movement {get; set;} = 30;
        
        public bool DarkVision { get; set;} =  false;

        public List<string> Languages = [];

        public List<PassiveHability> PassiveHabilities = [];

        public List<Advantage> Advantages = [];

        public List<DisAdvantage> DisAdvantages = [];

        public List<Resistance> Resistances = [];

        public List<Imunity> Imunities = [];

        public Dictionary<string, string> KnownSkills = [];

        //public List<Spell> Spells = [];

    }
}