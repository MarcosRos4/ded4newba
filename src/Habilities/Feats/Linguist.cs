using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ded4newba.src.Habilities.Feats
{
    public class Linguist : Feat
    {
        public Linguist(string language1, string language2, string language3){
            AttributeBonus.Attribute = "Intelligence";
            AttributeBonus.Number = 1;
            
            PassiveHability = new(
                "Linguist",
                " You can ably create written ciphers. Others can'"+
                "t decipher a code you create unless you teach them, they succe"+
                "ed on an Intelligence check (DC equal to your Intelligence sco"+
                "re + your proficiency bonus), or they use magic to decipher it."            );

            Languages.AddRange(
                [language1, language2, language3]
            );



        }
    }
}