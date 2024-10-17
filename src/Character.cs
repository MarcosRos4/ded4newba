using ded4newba.src.Proficiencies;
using ded4newba.Src.DnDClasses;
using ded4newba.Src.Races;
using ded4newba.Src.Backgrounds;

namespace ded4newba.Src
{
    public class Character
    {
        public string Name { get; set; }

        public int Level { get; set; }

        public int ProficiencyBonus { get; set; }

        public Race Race { get; set; }

        public DndClass DndClass { get; set; }
    
        public Background Background { get; set; }

        public int TotalLifePoints;

        public int CurrentLifePoints { get; set; }

        public int ArmorClass { get; set; }

        public int Iniciative { get; set; }

        public int Movement { get; set; }

        public Dictionary<string, int> AbilityScores { get; set; }
        // Strength, Dexterity, Constitution, Intelligence, Wisdom, Charisma

        public List<string> SavingThrows {get;set;}
        
        public List<Proficiency> Proficiencies {get; set;}

        public Character(DndClass dndClass, Race race, Background background, Dictionary<string, int> abilityscores, string name)
        {
            Race = race;
            DndClass = dndClass;
            Background = background;
            AbilityScores = abilityscores;
            Name = name;
            TotalLifePoints = DndClass.LifeDice + DndClass.ClassLevel * 2;
            Level = DndClass.ClassLevel;
            ArmorClass = 10 + AbilityScores["Dexterity"];
            Iniciative = GetAtributeBonus("Dexterity");
            Movement = Race.Movement;
            CurrentLifePoints = TotalLifePoints;
            SavingThrows = DndClass.SavingThrows;
            SetProfiencyBonus();
        }

        public int GetAtributeBonus(string attribute){
            return (int) Math.Floor((decimal) (AbilityScores[attribute] - 10) / 2);
        }

        public void SetProfiencyBonus(){
            ProficiencyBonus = (Level / 4) switch
            {
                <= 1 => 2, // lvl 1-4 => +2
                <= 2 => 3, // lvl 5-8 => +3
                <= 3 => 4, // lvl 8-12 => +4
                <= 4 => 6, // lvl 13-16 => +5
                _ => 6,    // lvl 17-20 => +6
            };
        }

        public void RollSavingThrow(string score){
            Random roll = new();
            int result = roll.Next(1,21);
            if (SavingThrows.Contains(score))
                Console.WriteLine($"{result} + {GetAtributeBonus(score)} + {ProficiencyBonus} = {result + GetAtributeBonus(score) + ProficiencyBonus}");
            else
                Console.WriteLine($"{result} + {GetAtributeBonus(score)} = {result + GetAtributeBonus(score)}");
        }

        public void RollAtack(string score){
            Random roll = new();
            int result = roll.Next(1,21);
            Console.WriteLine($"{result} + {GetAtributeBonus(score)} + {ProficiencyBonus} = {result + GetAtributeBonus(score) + ProficiencyBonus}");
        }
    }
}