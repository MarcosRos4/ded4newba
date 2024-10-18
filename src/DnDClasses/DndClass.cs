using ded4newba.src.Habilities;

namespace ded4newba.Src.DnDClasses
{
    public class DndClass
    {
        public int LifeDice { get; set; }

        public int ClassLevel { get; set; }

        public  List<string> SavingThrows {get; set;}

        public  List<Skill> KnownSkills = [];
        public Dictionary<Advantage, string> Advantages = [];

        public Dictionary<string, string> Habilities {get;set;}

    }
}