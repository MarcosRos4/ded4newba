namespace ded4newba.src.Habilities.Feats
{
    public class FeatRequirement(string atribute, bool conjurer, string armorweight)
    {
        // algum atributo ou "" para não ser requisito
        // caso houver, 13 é o número mínimo do atributo
        public string Atribute { get; } = atribute;
        // true ou false para não ser requisito
        public bool Conjurer { get; } = conjurer;
        // "Light", "Medium", "Heavy", ou "" para um não requisito
        public string Armorweight { get; } = armorweight;
    }
}