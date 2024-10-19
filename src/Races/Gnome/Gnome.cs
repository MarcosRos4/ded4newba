using ded4newba.src.Habilities;
using ded4newba.Src.Races;

namespace ded4newba.src.Races.Gnome
{
    public class Gnome : Race
    {
        readonly Advantage wisdom = new(
            "Gnome Cunning: Wisdom",
            "Wisdom",
            "Magic",
            "You have advantage on all Wisdom saving throws against magic."
        );
        readonly Advantage inteligence = new(
            "Gnome Cunning: Intelligence",
            "Intelligence",
            "Magic",
            "You have advantage on all Intelligence saving throws against magic."
        );
        readonly Advantage charisma = new(
            "Gnome Cunning: Charisma",
            "Charisma",
            "Magic",
            "You have advantage on all Charisma saving throws against magic."
        );


        public Gnome(){

            Movement = 25;
            
            DarkVision =  true;
            
            BonusAtributes.Add("Inteligence", 2);
            
            Languages.Add("Common");
            Languages.Add("Gnomish");

            Advantages.Add(charisma, "Charisma Saves Against Magic");
            Advantages.Add(wisdom, "Wisdom Saves Against Magic");
            Advantages.Add(inteligence, "Intelligence Saves Against Magic");
            
        }
    }
}