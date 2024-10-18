// See https://aka.ms/new-console-template for more information
using ded4newba.src.Backgrounds;
using ded4newba.src.DnDClasses;
using ded4newba.Src.Character;
using ded4newba.Src.Races;

Bard bard = new();
Race gnome = new();
Sage sage = new("Celestial", "Infernal");
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
    "Shmeb");

Console.WriteLine($"{shmeb.TotalLifePoints} pontos de vida");
Console.WriteLine($"Nível: {shmeb.Level}");
Console.WriteLine($"Meu nome é: {shmeb.Name}");

shmeb.RollAtack("Strength");
Console.WriteLine($"");
shmeb.RollSavingThrow("Charisma", "");
