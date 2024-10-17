using ded4newba.Src.PassiveHabilities;

namespace ded4newba.src.Races.Elf
{
    public class WoodElf : Elf
    {
        readonly PassiveHability maskofthewild = new(
            "Mask of the Wild",
            "You can attempt to hide even when "+
            "you are only lightly obscured by foliage, heavy rain, "+
            "falling snow, mist, and other natural phenomena."
        );

        public WoodElf(){
            BonusAtributes.Add("Wisdom", 1);
            Movement += 5;
            PassiveHabilities.Add(maskofthewild);
        }
    }
}