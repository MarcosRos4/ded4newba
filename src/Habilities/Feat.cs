using ded4newba.Src.Habilities;

namespace ded4newba.src.Habilities
{
    public class Feat
    {
        //public FeatRequirement Requirement { get; set; }

        public string Name { get; set; }

        public PassiveHability PassiveHability { get; set; }

        public AttributeBonus AttributeBonus { get; set; } = new("", 0);

        public List<Skill> Skills { get; set; } =[];

        public List<string> Languages { get; set; } =[];

        // TODO adicionar imunidades, alerta é imune a ser surpreso

        // objeto vantagem, string condição (poisoned, charmed ...) ou pericia (Deception, Insight ...)
        public List<Advantage> Advantages  = [];

        public int BonusLifePoints { get; set; } = 0;

        // nenhuma, armadura leve + escudos, média, pesada==todas"
        //public List<string> ArmorProficiency =[""];
        
                


    }
}