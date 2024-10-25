using ded4newba.src.Habilities;
using ded4newba.Src.Habilities;

namespace ded4newba.Src.Backgrounds
{
    public class Background
    {
        public string Name { get; set; }
        // lista de Skill que o background tem
        public List<Skill> KnownSkills { get; set; } = [];
        // lista de string de linguagens que o background tem
        public List<string> Languages { get; set; } = [];
        // dicionario de string,string de passivas que o background tem
        public List<PassiveHability> PassiveHabilities { get; set; } = [];
    }
}
