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
                Incant = "Disarm your <target>",
                Type = SpellType.EForce
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
                Name = "Lesser Investment",
                Level = 3,
                Incant = "build a Lesser Investment",
                Type = SpellType.EForce
            });
            First.Add(new Scroll
            {
                Name = "Fortress",
                Level = 1,
                Incant = "build a Fortress",
                Type = SpellType.EForce
            });
            First.Add(new Scroll(1, SpellFlavor.Stone));
            First.Add(new Scroll(1, SpellFlavor.Lighting));
            First.Add(new Scroll(1, SpellFlavor.Ice));
            First.Add(new Scroll(1, SpellFlavor.Flame));
            Second.Add(new Scroll
            {
                Name = "Weapon Shield",
                Level = 2,
                Incant = "a Weapon Shield",
                Type = SpellType.Protection
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
                Name = "Slow",
                Level = 2,
                Incant = "Slow you",
                Type = SpellType.Binding
            });
            Second.Add(new Scroll
            {
                Name = "Mend Armor",
                Level = 2,
                Incant = "Mend 10 Armor",
                Type = SpellType.EForce
            });
            Second.Add(new Scroll(2, SpellFlavor.Stone));
            Second.Add(new Scroll(2, SpellFlavor.Lighting));
            Second.Add(new Scroll(2, SpellFlavor.Ice));
            Second.Add(new Scroll(2, SpellFlavor.Flame));
            Third.Add(new Scroll
            {
                Name = "Bind",
                Level = 3,
                Incant = "Bind you",
                Type = SpellType.Binding
            });
            Third.Add(new Scroll
            {
                Name = "Shatter",
                Level = 3,
                Incant = "Shatter your <target>",
                Type = SpellType.EForce
            });
            Third.Add(new Scroll
            {
                Name = "Wall of Force",
                Level = 3,
                Incant = "build a Wall of Force",
                Type = SpellType.EForce
            });
            Third.Add(new Scroll
            {
                Name = "Solidfy",
                Level = 3,
                Incant = "Solidfy you",
                Type = SpellType.EForce
            });
            Third.Add(new Scroll(3, SpellFlavor.Stone));
            Third.Add(new Scroll(3, SpellFlavor.Lighting));
            Third.Add(new Scroll(3, SpellFlavor.Ice));
            Third.Add(new Scroll(3, SpellFlavor.Flame));
            Fourth.Add(new Scroll
            {
                Name = "Awaken",
                Level = 4,
                Incant = "I Awaken you from commands",
                Type = SpellType.Fixing
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
                Name = "Enhanced Blade",
                Level = 4,
                Incant = "an Enhanced Blade",
                Type = SpellType.Protection
            });
            Fourth.Add(new Scroll
            {
                Name = "Shun",
                Level = 4,
                Incant = "Shun me",
                Type = SpellType.Commands
            });
            Fourth.Add(new Scroll(4, SpellFlavor.Stone));
            Fourth.Add(new Scroll(4, SpellFlavor.Lighting));
            Fourth.Add(new Scroll(4, SpellFlavor.Ice));
            Fourth.Add(new Scroll(4, SpellFlavor.Flame));
            Fifth.Add(new Scroll
            {
                Name = "Release",
                Level = 5,
                Incant = "I Release you from binding",
                Type = SpellType.Fixing
            });
            Fifth.Add(new Scroll
            {
                Name = "Spell Shield",
                Level = 5,
                Incant = "a Spell Shield",
                Type = SpellType.Protection
            });
            Fifth.Add(new Scroll
            {
                Name = "Subjugate",
                Level = 5,
                Incant = "Subjugate you",
                Type = SpellType.EForce
            });
            Fifth.Add(new Scroll
            {
                Name = "Lesser Magic Storm",
                Level = 5,
                Incant = "Lesser Magic Storm",
                Type = SpellType.Evocation
            });
            Fifth.Add(new Scroll(5, SpellFlavor.Stone));
            Fifth.Add(new Scroll(5, SpellFlavor.Lighting));
            Fifth.Add(new Scroll(5, SpellFlavor.Ice));
            Fifth.Add(new Scroll(5, SpellFlavor.Flame));
            Sixth.Add(new Scroll
            {
                Name = "Elemental Shield",
                Level = 6,
                Incant = "an Elemental Shield",
                Type = SpellType.Protection
            });
            Sixth.Add(new Scroll
            {
                Name = "Sleep",
                Level = 6,
                Incant = "Sleep",
                Type = SpellType.Commands
            });
            Sixth.Add(new Scroll
            {
                Name = "Wizard Lock",
                Level = 6,
                Incant = "build a Wizard Lock",
                Type = SpellType.EForce
            });
            Sixth.Add(new Scroll(6, SpellFlavor.Stone));
            Sixth.Add(new Scroll(6, SpellFlavor.Lighting));
            Sixth.Add(new Scroll(6, SpellFlavor.Ice));
            Sixth.Add(new Scroll(6, SpellFlavor.Flame));
            Seventh.Add(new Scroll
            {
                Name = "Charm",
                Level = 7,
                Incant = "be Charmed",
                Type = SpellType.Commands
            });
            Seventh.Add(new Scroll
            {
                Name = "Confine",
                Level = 7,
                Incant = "Confine you",
                Type = SpellType.Binding
            });
            Seventh.Add(new Scroll(7, SpellFlavor.Stone));
            Seventh.Add(new Scroll(7, SpellFlavor.Lighting));
            Seventh.Add(new Scroll(7, SpellFlavor.Ice));
            Seventh.Add(new Scroll(7, SpellFlavor.Flame));
            Eigth.Add(new Scroll
            {
                Name = "Dispel",
                Level = 8,
                Incant = "to Dispel",
                Type = SpellType.Protection
            });
            Eigth.Add(new Scroll
            {
                Name = "Reflect Magic",
                Level = 8,
                Incant = "a Reflect Magic",
                Type = SpellType.Protection
            });
            Eigth.Add(new Scroll
            {
                Name = "Stun Limb",
                Level = 8,
                Incant = "a Stun your <limb>",
                Type = SpellType.EForce
            });
            Eigth.Add(new Scroll(8, SpellFlavor.Stone));
            Eigth.Add(new Scroll(8, SpellFlavor.Lighting));
            Eigth.Add(new Scroll(8, SpellFlavor.Ice));
            Eigth.Add(new Scroll(8, SpellFlavor.Flame));
            Ninth.Add(new Scroll
            {
                Name = "Circle of Power",
                Level = 9,
                Incant = "build a Circle of Power",
                Type = SpellType.EForce
            });
            Ninth.Add(new Scroll
            {
                Name = "Magic Storm",
                Level = 9,
                Incant = "Magic Storm",
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
            Ninth.Add(new Scroll(9, SpellFlavor.Stone));
            Ninth.Add(new Scroll(9, SpellFlavor.Lighting));
            Ninth.Add(new Scroll(9, SpellFlavor.Ice));
            Ninth.Add(new Scroll(9, SpellFlavor.Flame));
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
