namespace ded4newba.src.Habilities.Feats
{
    public class AttributeBonus(string attribute, int number)
    {
        public string Attribute { get; set; } = attribute;
        public int Number { get; set; } = number;
    }
}