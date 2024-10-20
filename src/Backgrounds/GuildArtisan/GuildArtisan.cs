using ded4newba.Src.Backgrounds;

namespace ded4newba.src.Backgrounds.GuildArtisan
{
    public class GuildArtisan : Background
    {
        public GuildArtisan(string language){
            
            KnownSkills.AddRange([
                new(
                "Insight",
                "Wisdom",
                true,
                false
                ),
                new(
                "Persuasion",
                "Charisma",
                true,
                false
                ),
                new(
                "Artisan's Tools",
                "Dexterity",
                true,
                false
                )
            ]);
            
            Languages.Add(language);

            PassiveHabilities.Add(new(
            "Guild Associate",
            "As a captive and respected member of the guild, you can count on certain "+
            "benefits guaranteed by the society. Your comrades, guild members, will pr"+
            "ovide you with lodging and food if necessary, and will pay for your funer"+
            "al if need be. In some cities and villages, a guild hall offers a central"+
            " place to meet other professionals, which can be a good place to meet emp"+
            "loyers, allies, and potential employees. Guilds often hold tremendous pol"+
            "itical power. If you are accused of a crime, your guild will support you "+
            "if a good defense can be presented to prove your innocence or if the crim"+
            "e is justifiable. You can also gain access to powerful political figures "+
            "through the guild, if you are a well-positioned member. Such connections "+
            "may require donations of money or magical items to the guild's coffers. Y"+
            "ou must pay dues of 5 gp per month to the guild. If you fail to pay, you "+
            "will incur a debt to remain in the guild's good graces."
            ));
        }
    }
}