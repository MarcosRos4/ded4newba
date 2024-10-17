namespace ded4newba.src.Habilities
{
    public class Advantage(string name, string savingthrow, string effectname, string description)
    {
        public string Name { get; } = name;
        public string Savingthrow { get; } = savingthrow;
        public string Effectname { get; } = effectname; // o efeito ao qual se tem vantagem
        public string Description { get; } = description;
    }
}