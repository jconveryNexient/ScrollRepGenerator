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

        public Scroll() { }

        public Scroll(int level, SpellFlavor flavor)
        {
            Name = flavor.ToString() + " Bolt";
            Level = level;
            Incant = $"{CalculateDamage(level)} {flavor.ToString()} Bolt";
            Type = SpellType.Evocation;
        }

        public string FetchIncant()
        {
            switch (Type)
            {
                case SpellType.Binding: return "With binding force I " + Incant;
                case SpellType.Commands: return "I command you to " + Incant;
                case SpellType.EForce: return "With eldritch force I " + Incant;
                case SpellType.Evocation: return "I evoke a " + Incant;
                case SpellType.Protection: return "I protect you with " + Incant;
                case SpellType.Fixing: return Incant;
                default: return "Not a spell type I've heard of" + Incant;
            }
        }

        private string CalculateDamage(int level)
        { return (level * 5).ToString(); }

    }

    public enum SpellType { Binding, Commands, EForce, Evocation, Protection, Fixing}

    public enum SpellFlavor { Stone, Lighting, Ice, Flame }
}
