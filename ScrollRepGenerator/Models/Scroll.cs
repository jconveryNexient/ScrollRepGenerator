using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrollRepGenerator.Models
{
    public class Scroll
    {
        public int Number { get; set; }
        public string Incant { get; set; }
        public SpellType Type { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }

        public string FetchIncant()
        {
            switch(Type)
            {
                case SpellType.Binding: return "With mystic force I " + Incant;
                case SpellType.Command: return "I command you to " + Incant;
                case SpellType.EForce: return "With eldritch force I " + Incant;
                case SpellType.Evocation: return "I call forth " + Incant;
                case SpellType.Protective: return "I grant you the power " + Incant;
                case SpellType.SForce: return "I summon a force to " + Incant;
                default: return "Not a spell type I've heard of" + Incant;
            }
        }
    }

    public enum SpellType { Binding, Command, EForce, Evocation, Protective, SForce }
}
