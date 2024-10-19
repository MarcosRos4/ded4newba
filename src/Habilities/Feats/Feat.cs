using ded4newba.Src.PassiveHabilities;

namespace ded4newba.src.Habilities.Feats
{
    public class Feat
    {
        public FeatRequirement Requirement { get; set; }

        public PassiveHability PassiveHability { get; set; }

        public KeyValuePair<string, int> AttributeBonus { get; set; }

        public List<Skill> Skills =[];

        public List<string> Languages =[];

        public List<string> Resistances= [];

        public int Iniciative = 0;

        // objeto vantagem, string condição (poisoned, charmed ...)
        public Dictionary<Advantage, string> Advantages = [];

        public int BonusLifePoints=0;

        // nenhuma, armadura leve + escudos, média, pesada==todas
        public List<string> ArmorProficiency =[""];
        
                


    }
}