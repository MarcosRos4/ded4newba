using ded4newba.src.Habilities;
using ded4newba.Src.Habilities;

namespace ded4newba.Src.Races
{
    public class Race
    {
        public Dictionary<string, int> BonusAtributes = [];
        public int Movement {get; set;} = 30;
        
        public bool DarkVision { get; set;} =  false;

        public List<string> Languages = [];

        public List<PassiveHability> PassiveHabilities = [];

        // objeto vantagem, string condição (poisoned, charmed ...)
        public Dictionary<Advantage, string> Advantages = [];

        public List<DisAdvantage> DisAdvantages = [];

        public List<string> Resistances = [];

        public List<Imunity> Imunities = [];

        public List<Skill> KnownSkills = [];

        //public List<Spell> Spells = [];

    }
}