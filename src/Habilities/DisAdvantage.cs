using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ded4newba.src.Habilities
{
    public class DisAdvantage(string name, string savingthrow, string effectname, string description)
    {
        public string Name { get; } = name;
        public string Savingthrow { get; } = savingthrow;
        public string Effectname { get; } = effectname; // o efeito ao qual se tem DESvantagem
        public string Description { get; } = description;
    }
}