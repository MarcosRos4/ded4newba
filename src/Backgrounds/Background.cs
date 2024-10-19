using ded4newba.src.Habilities;
using ded4newba.Src.PassiveHabilities;

namespace ded4newba.Src.Backgrounds
{
    public class Background
    {
        // lista de Skill que o background tem
        public List<Skill> KnownSkills = [];
        // lista de string de linguagens que o background tem
        public List<string> Languages = [];
        // dicionario de string,string de passivas que o background tem
        public List<PassiveHability> PassiveHabilities = [];
    }
}
