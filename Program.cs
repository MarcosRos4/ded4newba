using ded4newba.src.Data;
using ded4newba.src.DnDClasses;
using ded4newba.src.Habilities;
using ded4newba.Src.Backgrounds;
using ded4newba.Src.Character;
using ded4newba.Src.Races;



Bard bard = new();
Race gnome = new JsonDataBase().GetRaceByName("Rock Gnome");
Background sage = new JsonDataBase().GetBackgroundByName("Sage");
sage.Languages = ["Celestial", "Abyssal"];
Feat linguist = new JsonDataBase().GetFeatByName("Linguist");
linguist.Languages = ["Dwarvish", "Elvish", "Hafling"];
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
    [linguist],
    false
    );

Console.Write($"{shmeb.TotalLifePoints} pontos de vida, Progressão: ");
foreach (var item in shmeb.LifePointsProgression)
{
    Console.Write($"{item}, ");
}
Console.WriteLine($"\nNível: {shmeb.Level}");
Console.WriteLine($"Meu nome é: {shmeb.Name}! Sou um {shmeb.Race.Name}");
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
    Console.WriteLine($"{item.Name}, Proficiente: {(item.Proficient ? "Sim" : "Não")}, " +
    $"Bonus: {item.Totalbonus}");
}

Console.WriteLine("\nIdiomas Conhecidos:");
foreach (var item in shmeb.Languages)
{
    Console.WriteLine(item);
}
Console.WriteLine("\nVantagem em: ");
foreach (var item in shmeb.Advantages)
{
    Console.WriteLine($"{item.Effectname}");
}
Console.WriteLine("\nPassivas: ");

foreach (var item in shmeb.PassiveHabilities)
{
    Console.WriteLine($"\nNome da Passiva: {item.Name}\nDescrição da Passiva: {item.Description}");
}