// See https://aka.ms/new-console-template for more information
using ded4newba.src.DnDClasses;
using ded4newba.Src;
using ded4newba.Src.Races;

Bard bard = new();
Race gnome = new();
Character shmeb = new(
    bard,
    gnome,
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

Console.WriteLine(
shmeb.TotalLifePoints);
Console.WriteLine(
shmeb.Level);
Console.WriteLine(
shmeb.Name);

shmeb.RollAtack("Strength");
shmeb.RollSavingThrow("Charisma");
