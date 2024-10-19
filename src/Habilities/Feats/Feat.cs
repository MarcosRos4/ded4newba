using ded4newba.Src.PassiveHabilities;

namespace ded4newba.src.Habilities.Feats
{
    public class Feat
    {
        //public FeatRequirement Requirement { get; set; }

        public PassiveHability PassiveHability { get; set; }

        public AttributeBonus AttributeBonus { get; set; } = new("", 0);

        public List<Skill> Skills =[];

        public List<string> Languages =[];

        public List<string> Resistances= [];

        public int Initiative = 0;

        // TODO adicionar imunidades, alerta é imune a ser surpreso

        // objeto vantagem, string condição (poisoned, charmed ...) ou pericia (Deception, Insight ...)
        public Dictionary<Advantage, string> Advantages = [];

        public int BonusLifePoints=0;

        // nenhuma, armadura leve + escudos, média, pesada==todas"
        //public List<string> ArmorProficiency =[""];
        
                


    }
}