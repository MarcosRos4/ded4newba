namespace ded4newba.src.Habilities
{
    public class Resistance(string name, string damagetype, string description)
    {
        public string Name { get; } = name;
        public string Damagetype { get; } = damagetype;
        public string Description { get; } = description;
    }
}