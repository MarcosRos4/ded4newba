using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ded4newba.src.Habilities;
using ded4newba.Src.PassiveHabilities;

namespace ded4newba.src.Races.Gnome
{
    public class RockGnome : Gnome
    {
        readonly PassiveHability artificerlore = new(
            "Artificer's Lore",
            "Whenever you make an Intelligence (History) check related to magic items, alchemical "+ 
            "objects, or technological devices, you can add twice your proficiency bonus, instead "+
            "of any proficiency bonus you normally apply."
        );

        readonly Advantage ADVartificerlore = new(
            "Artificer's Lore",
            "Intelligence",
            "",
            "Whenever you make an Intelligence (History) check related to magic items, alchemical"+
            " objects, or technological devices, you can add twice your proficiency bonus, instea"+
            "d of any proficiency bonus you normally apply."
        );

        readonly PassiveHability tinker = new(
            "Tinker",
            "You have proficiency with artisan's tools (tinker's tools). Using those tools, you "+
            "can spend 1 hour and 10 gp worth of materials to construct a Tiny clockwork device (AC 5, 1 hp). "
        );

        public RockGnome(){
            
            BonusAtributes.Add("Constitution", 1);

            PassiveHabilities.Add(artificerlore);
            PassiveHabilities.Add(tinker);

            Advantages.Add(ADVartificerlore, "Artificer's Lore");
        }
    }
}