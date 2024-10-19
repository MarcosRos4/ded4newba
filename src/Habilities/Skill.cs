namespace ded4newba.src.Habilities
{
    public class Skill(string name, string attribute, bool proficient, bool superproficient)
    {
        public string Name { get; set; } = name;
        public string Attribute { get; set; } = attribute;
        public bool Proficient { get; set; } = proficient;
        public bool SuperProficient { get; set; } = superproficient;

        public int totalbonus = 0;

        

    }
}