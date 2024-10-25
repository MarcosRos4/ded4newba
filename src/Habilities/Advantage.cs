namespace ded4newba.src.Habilities
{
    public class Advantage(string name, string attributeused, string effectname, string description)
    {
        public string Name { get; set; } = name;
        public string AttributeUsed { get; set; } = attributeused;
        public string Effectname { get; set; } = effectname; // o efeito ao qual se tem vantagem
        public string Description { get; set; } = description;
    }
}