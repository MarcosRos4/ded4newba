using ded4newba.src.Backgrounds.Sage;
using ded4newba.src.DnDClasses;
using ded4newba.src.Habilities.Feats;
using ded4newba.src.Races.Gnome;
using ded4newba.Src.Backgrounds;
using ded4newba.Src.Character;
using ded4newba.Src.Races;

Bard bard = new();
Race gnome = new RockGnome();
Background sage = new Sage("Celestial", "Infernal");
Feat keenMind = new KeenMind();
Feat linguist = new Linguist("Abissal", "Dwarvish", "Elvish");
Feat alert = new Alert();
Feat actor =  new Actor();
Character shmeb = new(
    bard,
    gnome,
    sage,
    new Dictionary<string, int>
    {
        {"Strength", 18},
        {"Dexterity", 15},
        {"Constitution", 15},        
        {"Intelligence", 15},        
        {"Wisdom", 15},        
        {"Charisma", 12},
    },
    "Shmeb",
    new Dictionary<string, Feat> {{"Keen Mind", keenMind}, {"Linguist", linguist}, {"Alert", alert}, {"Actor", actor}}
    );
Console.Clear();
Console.WriteLine($"{shmeb.TotalLifePoints} pontos de vida");
Console.WriteLine($"Nível: {shmeb.Level}");
Console.WriteLine($"Meu nome é: {shmeb.Name}");
Console.WriteLine($"Iniciativa: {shmeb.Initiative}");
shmeb.RollAtack("Strength");
Console.WriteLine($"");
shmeb.RollSavingThrow("Charisma", "");
foreach (var item in shmeb.AbilityScores)
{
    Console.WriteLine($"{item.Key}, {item.Value}, +{shmeb.GetAtributeBonus(item.Key)}");
}
Console.WriteLine("\nTestes de Resistência:");
foreach (var item in shmeb.SavingThrows)
{
    Console.WriteLine($"{item} {(shmeb.GetAtributeBonus(item) + shmeb.ProficiencyBonus)}");
}
Console.WriteLine("\nPerícias:");
foreach (var item in shmeb.Skills)
{
    Console.WriteLine($"{item.Key}, Proficiente: {(item.Value.Proficient ? "Sim" : "Não")}, "+
    $"Bonus: {item.Value.totalbonus}");
}

Console.WriteLine("\nIdiomas Conhecidos:");
foreach (var item in shmeb.Languages)
{
    Console.WriteLine(item);
}
Console.WriteLine("\nVantagem em: ");
foreach (var item in shmeb.Advantages)
{
    Console.WriteLine($"{item.Value}");
}
Console.WriteLine("\nPassivas: ");

foreach (var item in shmeb.PassiveHabilities)
{
    Console.WriteLine($"\nNome da Passiva: {item.Name}\nDescrição da Passiva: {item.Description}");
}