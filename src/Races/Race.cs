using ded4newba.src.Habilities;
using ded4newba.src.Habilities.Feats;
using ded4newba.Src.Habilities;

namespace ded4newba.Src.Races
{
    public class Race
    {
        public string Name { get; set;}
        public Dictionary<string, int> BonusAtributes {get; set;} = [];
        public int Movement {get; set;} = 30;
        
        public bool DarkVision { get; set;} =  false;

        public List<string> Languages { get; set; } = [];

        public List<PassiveHability> PassiveHabilities { get; set; } = [];

        // objeto vantagem, string condição (poisoned, charmed ...)
        public List<Advantage> Advantages = [];

        public List<DisAdvantage> DisAdvantages = [];

        public List<string> Resistances { get; set; } = [];

        public List<Imunity> Imunities { get; set; } = [];

        public List<Skill> KnownSkills { get; set; } = [];

        public Dictionary<string, Feat> Feats { get; set; } = [];
        //public List<Spell> Spells = [];

    }
}