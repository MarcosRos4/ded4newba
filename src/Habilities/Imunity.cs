namespace ded4newba.src.Habilities
{
    public class Imunity(string name, string effectname, string description)
    {
        public string Name { get; } = name;
        public string Effectname { get; } = effectname;
        public string Description { get; } = description;
    }
}