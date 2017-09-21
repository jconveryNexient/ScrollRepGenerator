using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrollRepGenerator.Models
{
    public class ScrollCase
    {
        public List<Scroll> First { get; set; } = new List<Scroll>();
        public List<Scroll> Second { get; set; } = new List<Scroll>();
        public List<Scroll> Third { get; set; } = new List<Scroll>();
        public List<Scroll> Fourth { get; set; } = new List<Scroll>();
        public List<Scroll> Fifth { get; set; } = new List<Scroll>();
        public List<Scroll> Sixth { get; set; } = new List<Scroll>();
        public List<Scroll> Seventh { get; set; } = new List<Scroll>();
        public List<Scroll> Eigth { get; set; } = new List<Scroll>();
        public List<Scroll> Ninth { get; set; } = new List<Scroll>();

        public ScrollCase()
        {
            First.Add(new Scroll
            {
                Name = "Disarm",
                Level = 1,
                Incant = "Disarm your (item)",
                Type = SpellType.SForce
            });
            First.Add(new Scroll
            {
                Name = "Light",
                Level = 1,
                Incant = "build a Light",
                Type = SpellType.EForce
            });
            First.Add(new Scroll
            {
                Name = "Stone bolt",
                Level = 1,
                Incant = "a Stone Bolt",
                Type = SpellType.Evocation
            });
            First.Add(new Scroll
            {
                Name = "Fortress",
                Level = 1,
                Incant = "build a Fortress",
                Type = SpellType.SForce
            });
            Second.Add(new Scroll
            {
                Name = "Lightning Bolt",
                Level = 2,
                Incant = "a Lightning Bolt",
                Type = SpellType.Evocation
            });
            Second.Add(new Scroll
            {
                Name = "Magic Armor",
                Level = 2,
                Incant = "of a Magic Armor",
                Type = SpellType.Protective
            });
            Second.Add(new Scroll
            {
                Name = "Pin",
                Level = 2,
                Incant = "Pin you",
                Type = SpellType.Binding
            });
            Second.Add(new Scroll
            {
                Name = "Repel",
                Level = 2,
                Incant = "Repel you",
                Type = SpellType.Binding
            });
            Second.Add(new Scroll
            {
                Name = "Shield",
                Level = 2,
                Incant = "of a Shield",
                Type = SpellType.Protective
            });
            Third.Add(new Scroll
            {
                Name = "Bind",
                Level = 3,
                Incant = "Bind you",
                Type = SpellType.Binding
            });
            Third.Add(new Scroll
            {
                Name = "Ice Bolt",
                Level = 3,
                Incant = "an Ice Bolt",
                Type = SpellType.Evocation
            });
            Third.Add(new Scroll
            {
                Name = "Lesser Investment",
                Level = 3,
                Incant = "build a Lesser Investment",
                Type = SpellType.EForce
            });
            Third.Add(new Scroll
            {
                Name = "Shatter",
                Level = 3,
                Incant = "Shatter <item>",
                Type = SpellType.SForce
            });
            Third.Add(new Scroll
            {
                Name = "Wall of Force",
                Level = 3,
                Incant = "build a Wall",
                Type = SpellType.EForce
            });
            Fourth.Add(new Scroll
            {
                Name = "Awaken",
                Level = 4,
                Incant = "Awaken",
                Type = SpellType.Command
            });
            Fourth.Add(new Scroll
            {
                Name = "Banish",
                Level = 4,
                Incant = "Banish you",
                Type = SpellType.EForce
            });
            Fourth.Add(new Scroll
            {
                Name = "Elemental Blade",
                Level = 4,
                Incant = "an Elemental Blade",
                Type = SpellType.Protective
            });
            Fourth.Add(new Scroll
            {
                Name = "Flame Bolt",
                Level = 4,
                Incant = "a Flame Bolt",
                Type = SpellType.Evocation
            });
            Fourth.Add(new Scroll
            {
                Name = "Shun",
                Level = 4,
                Incant = "Shun me",
                Type = SpellType.Command
            });
            Fifth.Add(new Scroll
            {
                Name = "Release",
                Level = 5,
                Incant = "Release you",
                Type = SpellType.Binding
            });
            Fifth.Add(new Scroll
            {
                Name = "Spell Shield",
                Level = 5,
                Incant = "of a Spell Shield",
                Type = SpellType.Protective
            });
            Fifth.Add(new Scroll
            {
                Name = "Stone Storm",
                Level = 5,
                Incant = "a Stone Storm",
                Type = SpellType.Evocation
            });
            Fifth.Add(new Scroll
            {
                Name = "Web",
                Level = 5,
                Incant = "Web you",
                Type = SpellType.Binding
            });
            Sixth.Add(new Scroll
            {
                Name = "Elemental Shield",
                Level = 6,
                Incant = "of an Elemental Shield",
                Type = SpellType.Protective
            });
            Sixth.Add(new Scroll
            {
                Name = "Enflame",
                Level = 6,
                Incant = "Enflame <item>",
                Type = SpellType.SForce
            });
            Sixth.Add(new Scroll
            {
                Name = "Lightning Storm",
                Level = 6,
                Incant = "a Lightning Storm",
                Type = SpellType.Evocation
            });
            Sixth.Add(new Scroll
            {
                Name = "Magic Blade",
                Level = 6,
                Incant = "of a Magic Blade",
                Type = SpellType.Protective
            });
            Sixth.Add(new Scroll
            {
                Name = "Sleep",
                Level = 6,
                Incant = "Sleep",
                Type = SpellType.Command
            });
            Seventh.Add(new Scroll
            {
                Name = "Charm",
                Level = 7,
                Incant = "be Charmed",
                Type = SpellType.Command
            });
            Seventh.Add(new Scroll
            {
                Name = "Confine",
                Level = 7,
                Incant = "Confine you",
                Type = SpellType.Binding
            });
            Seventh.Add(new Scroll
            {
                Name = "Destroy",
                Level = 7,
                Incant = "Destroy <item>",
                Type = SpellType.SForce
            });
            Seventh.Add(new Scroll
            {
                Name = "Ice Storm",
                Level = 7,
                Incant = "an Ice Storm",
                Type = SpellType.Evocation
            });
            Seventh.Add(new Scroll
            {
                Name = "Subjugate",
                Level = 7,
                Incant = "Subjugate you",
                Type = SpellType.EForce
            });
            Eigth.Add(new Scroll
            {
                Name = "Dispel",
                Level = 8,
                Incant = "to Dispel",
                Type = SpellType.Protective
            });
            Eigth.Add(new Scroll
            {
                Name = "Dragon's Breath",
                Level = 8,
                Incant = "a Dragon's Breath",
                Type = SpellType.Evocation
            });
            Eigth.Add(new Scroll
            {
                Name = "Reflect Magic",
                Level = 8,
                Incant = "of a Reflect Magic",
                Type = SpellType.Protective
            });
            Eigth.Add(new Scroll
            {
                Name = "Solidfy",
                Level = 8,
                Incant = "Solidfy you",
                Type = SpellType.EForce
            });
            Eigth.Add(new Scroll
            {
                Name = "Wizard Lock",
                Level = 8,
                Incant = "build a Wizard Lock",
                Type = SpellType.EForce
            });
            Ninth.Add(new Scroll
            {
                Name = "Circle of Power",
                Level = 9,
                Incant = "build a Circle of Power",
                Type = SpellType.EForce
            });
            Ninth.Add(new Scroll
            {
                Name = "Stone Blast",
                Level = 9,
                Incant = "a Stone Blast",
                Type = SpellType.Evocation
            });
            Ninth.Add(new Scroll
            {
                Name = "Lightning Blast",
                Level = 9,
                Incant = "a Lightning Blast",
                Type = SpellType.Evocation
            });
            Ninth.Add(new Scroll
            {
                Name = "Ice Blast",
                Level = 9,
                Incant = "an Ice Blast",
                Type = SpellType.Evocation
            });
            Ninth.Add(new Scroll
            {
                Name = "Flame Blast",
                Level = 9,
                Incant = "a Flame Blast",
                Type = SpellType.Evocation
            });
            Ninth.Add(new Scroll
            {
                Name = "Magic Storm",
                Level = 9,
                Incant = "a Magic Storm",
                Type = SpellType.Evocation
            });
            Ninth.Add(new Scroll
            {
                Name = "Prison",
                Level = 9,
                Incant = "build a Prison",
                Type = SpellType.EForce
            });
            Ninth.Add(new Scroll
            {
                Name = "Ward",
                Level = 9,
                Incant = "build a Ward",
                Type = SpellType.EForce
            });
        }

        public List<Scroll> ConvertToList()
        {
            List<Scroll> list = new List<Scroll>();
            list.AddRange(First.Where(_ => _.Number > 0).ToList());
            list.AddRange(Second.Where(_ => _.Number > 0).ToList());
            list.AddRange(Third.Where(_ => _.Number > 0).ToList());
            list.AddRange(Fourth.Where(_ => _.Number > 0).ToList());
            list.AddRange(Fifth.Where(_ => _.Number > 0).ToList());
            list.AddRange(Sixth.Where(_ => _.Number > 0).ToList());
            list.AddRange(Seventh.Where(_ => _.Number > 0).ToList());
            list.AddRange(Eigth.Where(_ => _.Number > 0).ToList());
            list.AddRange(Ninth.Where(_ => _.Number > 0).ToList());
            return list;
        }
    }
}
