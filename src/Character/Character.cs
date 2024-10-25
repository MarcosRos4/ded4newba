using ded4newba.Src.DnDClasses;
using ded4newba.Src.Races;
using ded4newba.Src.Backgrounds;
using ded4newba.src.Habilities;
using ded4newba.src.Habilities.Feats;
using ded4newba.Src.Habilities;
using System.Text.Json;
using ded4newba.src.Data;

namespace ded4newba.Src.Character
{
    public class Character
    {
        readonly Random Roll = new();
        public string Name { get; set; }

        public int Level { get; set; }

        public int ProficiencyBonus { get; set; }

        public Race Race { get; set; } = new();

        public DndClass DndClass { get; set; } = new();
    
        public Background Background { get; set; } = new();

        public int TotalLifePoints { get; set; } 

        public List<int> LifePointsProgression { get; set; } = [];

        public int CurrentLifePoints { get; set; }

        public int ArmorClass { get; set; } = 0;

        public int Initiative { get; set; } = 0;

        public int Movement { get; set; } = 0;

        public Dictionary<string, int> AbilityScores { get; set; } = [];
        // Strength, Dexterity, Constitution, Intelligence, Wisdom, Charisma

        public List<string> SavingThrows { get; set; } = [];

        // <Nome da Skill, Skill>
        public List<Skill> Skills { get; set; } =  new JsonDataBase().ReadAllSkills();

        public List<PassiveHability> PassiveHabilities { get; set; } = [];

        public List<string> Resistances { get; set; } = [];
        
        // a string pode ser dois tipos de info: efeito (poisoned, etc) ou
        // o nome de perícia a qual a vantagem se aplica, isso pra poder ser
        // utilizada tanto nas rolagens de save quanto de pericia
        public List<Advantage> Advantages = [];

        // nenhuma, armadura leve + escudos, média, pesada==todas
        //public string ArmorProficiency = "None";

        //public List<string> WeaponProficiency = [];

        public List<Feat> Feats { get; set; } = [];

        public List<string> Languages { get; set; } = [];


        public Character
        (
            DndClass dndClass,
            Race race,
            Background background,
            Dictionary<string, int> abilityscores,
            string name,
            List<Feat> feats,
            bool luck
        )
        {
            Race = race;
            DndClass = dndClass;
            Background = background;
            AbilityScores = abilityscores;
            Feats = feats;
            Name = name;
            TotalLifePoints = DndClass.LifeDice + GetAtributeBonus("Constitution"); 
            Level = DndClass.ClassLevel;
            ArmorClass = 10 + GetAtributeBonus("Dexterity");
            Movement = Race.Movement;
            SetProfiencyBonus();
            SetAllSkills();
            SetProficientSkills();
            SetPassiveHabilities();
            SetFeats();
            SetAdvantages();
            SetInitiative();
            SetLanguages();
            SetTotalLifePoints(luck);
            SetSavingThrows();
        }
        public void SetSavingThrows(){
            SavingThrows = DndClass.SavingThrows;
            if (Feats.FindIndex(feat => feat.Name == "Resilient") != -1)
            {
                SavingThrows.Add(Feats.Find(feat => feat.Name == "Resilient").AttributeBonus.Attribute);
            }
        }
        
        public void SetTotalLifePoints(bool luck){
            
            if (luck)
            {
                for (int i = 0; i < Level-1; i++)
                {
                    int roll = Roll.Next(2, DndClass.LifeDice);
                    LifePointsProgression.Add(roll);
                    TotalLifePoints += roll + GetAtributeBonus("Constitution");
                }
            }
            else
            {
                for (int i = 0; i < Level-1; i++)
                {
                    LifePointsProgression.Add(DndClass.LifeDice / 2 + 1);

                    TotalLifePoints += DndClass.LifeDice / 2 + 1 + GetAtributeBonus("Constitution");
                }
            }
            if (Feats.FindIndex(feat => feat.Name == "Tough") != -1)
            {
                TotalLifePoints += 2 * Level;
            }

            if (Feats.FindIndex(feat => feat.Name == "Dwarven Toughness") != -1)
            { 
                TotalLifePoints += Level;
            }
        }
        public void SetAdvantages(){
            foreach (var advantage in Race.Advantages)
            {
                Advantages.Add(advantage);
            }
            
        }
        public void SetInitiative(){
            Initiative += GetAtributeBonus("Dexterity");
            if (Feats.FindIndex(feat => feat.Name == "Alert") != -1)
            {
                Initiative += 5;
            }
        }

        public void SetLanguages(){
            Languages.AddRange(Background.Languages);
            Languages.AddRange(Race.Languages);
            if (Feats.FindIndex(feat => feat.Name == "Linguist") != -1)
            {
                Languages.AddRange(Feats.Find(feat => feat.Name == "Linguist").Languages);
            }
        }

        public void SetFeats(){
            
            foreach (var feat in Feats)
            {
                PassiveHabilities.Add(
                    feat.PassiveHability
                );

                if (feat.AttributeBonus.Attribute != "")
                {
                    AbilityScores[feat.AttributeBonus.Attribute] += feat.AttributeBonus.Number;
                }

                Advantages.AddRange(feat.Advantages);

            }
        }

        public void SetPassiveHabilities(){
            PassiveHabilities.AddRange(Background.PassiveHabilities);
            PassiveHabilities.AddRange(Race.PassiveHabilities);
            // class PassiveHabilities.AddRange(Background.PassiveHabilities);
        }

        public void SetAllSkills(){
            
            try
            {
                foreach (Skill skill in Skills)
                {  
                    skill.Totalbonus = GetAtributeBonus(skill.Attribute);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
            }
        }

        public void SetProficientSkills(){
            foreach (var backgroundSkill in Background.KnownSkills)
            {
                var skill = Skills.Find(skill => skill.Name == backgroundSkill.Name);
                skill.Totalbonus += ProficiencyBonus;

                skill.Totalbonus += backgroundSkill.SuperProficient ? ProficiencyBonus : 0;
            }

            foreach (var classSkill in DndClass.KnownSkills)
            {
               var skill = Skills.Find(skill => skill.Name == classSkill.Name);
                skill.Totalbonus += ProficiencyBonus;

                skill.Totalbonus += classSkill.SuperProficient ? ProficiencyBonus : 0;
            }
        }

        public int GetAtributeBonus(string attribute){
            return (int) Math.Floor((decimal) (AbilityScores[attribute] - 10) / 2);
        }

        public void SetProfiencyBonus(){
            ProficiencyBonus = (Level / 4.0) switch
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
            // checa o valor do item, que sempre é um efeito (poisoned,etc)
            if(Advantages.FindIndex(item => item.Effectname == condition) != -1)
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
                if (item.Proficient) // se for proficiente adiciona bonus de proficiencia
                {
                    firstRoll += ProficiencyBonus + GetAtributeBonus(item.Attribute);    
                    secondRoll += ProficiencyBonus + GetAtributeBonus(item.Attribute);

                    if (item.SuperProficient) // se for super-proficiente adiciona 2 * bonus de proficiencia
                        firstRoll += ProficiencyBonus + GetAtributeBonus(item.Attribute);    
                        secondRoll += ProficiencyBonus + GetAtributeBonus(item.Attribute);  
                }
                else
                { // se nao só adiciona o bonus de atributo
                    firstRoll += GetAtributeBonus(item.Attribute);    
                    secondRoll += GetAtributeBonus(item.Attribute); 
                }
            }

            // se houver vantagem ele pega o maior valor, se nao retorna o primeiro
            
            if(Advantages.FindIndex(item => item.Effectname == skill) != -1)
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