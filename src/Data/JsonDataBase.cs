using System.Text.Json;
using ded4newba.src.Habilities;
using ded4newba.Src.Backgrounds;
using ded4newba.Src.Races;

namespace ded4newba.src.Data
{
    public class JsonDataBase
    {
        private readonly string SkillsFilePath = "./src/Data/AllSkills.json";
        private readonly string BackgroundsFilePath = "./src/Data/Backgrounds.json";
        private readonly string FeatsFilePath = "./src/Data/Feats.json";
        private readonly string RacesFilePath = "./src/Data/Races.json";

        public List<Skill> ReadAllSkills()
        {
            if (!File.Exists(SkillsFilePath)) return [];

            string jsonString = File.ReadAllText(SkillsFilePath);
            return JsonSerializer.Deserialize<List<Skill>>(jsonString);
        }

        public List<Background> ReadAllBackgrounds()
        {
            if (!File.Exists(BackgroundsFilePath)) return [];

            string jsonString = File.ReadAllText(BackgroundsFilePath);
            return JsonSerializer.Deserialize<List<Background>>(jsonString);
        }

        public List<Feat> ReadAllFeats()
        {
            if (!File.Exists(FeatsFilePath)) return [];

            string jsonString = File.ReadAllText(FeatsFilePath);
            return JsonSerializer.Deserialize<List<Feat>>(jsonString);
        }

        public List<Race> ReadAllRaces()
        {
            if (!File.Exists(RacesFilePath)) return [];

            string jsonString = File.ReadAllText(RacesFilePath);
            return JsonSerializer.Deserialize<List<Race>>(jsonString);
        }

        public Skill GetSkillByName(string name)
        {
            var skills = ReadAllSkills();
            return skills.Find(skill => skill.Name == name);
        }

        public Background GetBackgroundByName(string name)
        {
            var backgrounds = ReadAllBackgrounds();
            return backgrounds.Find(background => background.Name == name);
        }

        public Feat GetFeatByName(string name)
        {
            var feats = ReadAllFeats();
            return feats.Find(feat => feat.Name == name);
        }

        public Race GetRaceByName(string name)
        {
            var races = ReadAllRaces();
            return races.Find(race => race.Name == name);
        }

        // private void Save(List<Skill> items)
        // {
        //     string jsonString = JsonSerializer.Serialize(items);
        //     File.WriteAllText(SkillsFilePath, jsonString);
        // }
    }
}