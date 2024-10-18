using ded4newba.Src.DnDClasses;
using ded4newba.Src.Races;
using ded4newba.Src.Backgrounds;
using ded4newba.src.Habilities;
using System.ComponentModel;

namespace ded4newba.Src.Character
{
    public class Character
    {
        public string Name { get; set; }

        public int Level { get; set; }

        public int ProficiencyBonus { get; set; }

        public Race Race = new();

        public DndClass DndClass = new();
    
        public Background Background = new();

        public int TotalLifePoints;

        public int CurrentLifePoints { get; set; }

        public int ArmorClass { get; set; }

        public int Iniciative { get; set; }

        public int Movement { get; set; }

        public Dictionary<string, int> AbilityScores = [];
        // Strength, Dexterity, Constitution, Intelligence, Wisdom, Charisma

        public List<string> SavingThrows = [];

        public Dictionary<string, Skill> Skills = [];

        public Dictionary<string, string> AllSkills = [];
        
        public Dictionary<string, string> PassiveHabilities = [];

        public List<string> Resistances = [];
        
        // a string pode ser dois tipos de info: efeito (poisoned, etc) ou
        // o nome de perícia a qual a vantagem se aplica, isso pra poder ser
        // utilizada tanto nas rolagens de save quanto de pericia
        public Dictionary<Advantage, string> Advantages = [];

        readonly Random Roll = new();

        public Character(DndClass dndClass, Race race, Background background, Dictionary<string, int> abilityscores, string name)
        {
            Race = race;
            DndClass = dndClass;
            Background = background;
            AbilityScores = abilityscores;
            Name = name;
            TotalLifePoints =
                DndClass.LifeDice +
                GetAtributeBonus("Constitution") +
                (DndClass.LifeDice / 2 + 1 + GetAtributeBonus("Constitution")) * (DndClass.ClassLevel - 1) ;
            Level = DndClass.ClassLevel;
            ArmorClass = 10 + AbilityScores["Dexterity"];
            Iniciative = GetAtributeBonus("Dexterity");
            Movement = Race.Movement;
            CurrentLifePoints = TotalLifePoints;
            SavingThrows = DndClass.SavingThrows;
            SetProfiencyBonus();
            SetAllSkills();
            SetProficientSkills();
            SetPassiveHabilities();
        }

        public void SetAllSkills(){
            
            try
            {   // lê o arquivo
                var file = File.ReadAllLines("./src/Character/AllSkills.txt");
                Skill skill = new("","",false, false);
                foreach (var line in file)
                {   // para cada linha divide a linha em 2 partes,
                    // nome, atributo
                    var split = line.Split('=');
                    skill.Name = split[0];
                    skill.Attribute = split[1];
                    Skills.Add(skill.Name,skill);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
            }
        }

        public void SetPassiveHabilities(){
            foreach (var hability in Background.PassiveHabilities)
            {
                PassiveHabilities.Add(hability.Key, hability.Value);
            }

            // foreach (var hability in DndClass.PassiveHabilities)
            // {
            //     PassiveHabilities.Add(hability.Key, hability.Value);
            // }            
        }

        public void SetProficientSkills(){
            foreach (var skill in Background.KnownSkills)
            {
                Skills[skill.Name] = skill;
            }

            foreach (var skill in DndClass.KnownSkills)
            {
                Skills[skill.Name] = skill;
            }
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

        public int RollSavingThrow(string score, string condition){
            
            int firstRoll = Roll.Next(1,21);
            int secondRoll = Roll.Next(1,21);

            // se tem proeficiencia no teste de resistencia, adiciona
            if (SavingThrows.Contains(score))
            firstRoll += GetAtributeBonus(score); secondRoll += GetAtributeBonus(score); 
            
            // se tem vantagem escolhe o maior valor
            foreach (var advantage in Advantages) // checa o valor do item, que sempre é um efeito (poisoned,etc)
            if(advantage.Value == condition)
            return Math.Max(firstRoll, secondRoll);
            
            return firstRoll;
        }

        public void RollAtack(string score){
            
            int result = Roll.Next(1,21);
            
            Console.WriteLine($"{score} Atack Roll: {result} + {GetAtributeBonus(score)} + {ProficiencyBonus} = {result + GetAtributeBonus(score) + ProficiencyBonus}");
        }
    
        public int RollSkillCheck(string skill){
            int firstRoll = Roll.Next(1,21);
            int secondRoll = Roll.Next(1,21);


            foreach (var item in Skills) // percorre todas as pericias
            {
                if (item.Value.Proficient) // se for proficiente adiciona bonus de proficiencia
                {
                    firstRoll += ProficiencyBonus + GetAtributeBonus(item.Value.Attribute);    
                    secondRoll += ProficiencyBonus + GetAtributeBonus(item.Value.Attribute);

                    if (item.Value.SuperProficient) // se for super-proficiente adiciona 2 * bonus de proficiencia
                        firstRoll += ProficiencyBonus + GetAtributeBonus(item.Value.Attribute);    
                        secondRoll += ProficiencyBonus + GetAtributeBonus(item.Value.Attribute);  
                }
                else
                { // se nao só adiciona o bonus de atributo
                    firstRoll += GetAtributeBonus(item.Value.Attribute);    
                    secondRoll += GetAtributeBonus(item.Value.Attribute); 
                }
            }

            // se houver vantagem ele pega o maior valor, se nao retorna o primeiro
            foreach (var advantage in Advantages)
            if(advantage.Value == skill)
            return Math.Max(firstRoll, secondRoll);
            
            return firstRoll;
            
        }
    
        public void TakeDamage(Dictionary<string, int> damageSum){
            
            foreach (var damage in damageSum)
            {
                if (Resistances.Contains(damage.Key) )
                {
                    CurrentLifePoints -= damage.Value / 2;
                    break;
                }

                CurrentLifePoints -= damage.Value;
            }
        }

        public void Heal(int healthpoints){
            CurrentLifePoints += healthpoints;
        }
    }
}