using ded4newba.Src.DnDClasses;

namespace ded4newba.src.DnDClasses
{
    public class Bard : DndClass
    {
        public Bard(){
            LifeDice = 8;
            ClassLevel = 10;
            SavingThrows = ["Wisdom", "Charisma"];
        }
    }
}