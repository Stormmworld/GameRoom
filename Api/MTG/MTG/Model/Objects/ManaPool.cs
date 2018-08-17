using MTG.Enumerations;
using MTG.Model.Objects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MTG.Model.Objects
{
    public class ManaPool
    {
        #region Properties
        public List<Mana> BlackMana { get; set; }
        public List<Mana> BlueMana { get; set; }
        public List<Mana> ColorlessMana { get; set; }
        public List<Mana> GreenMana { get; set; }
        public List<Mana> RedMana { get; set; }
        public List<Mana> WhiteMana { get; set; }
        #endregion

        #region Constructors
        public ManaPool()
        {
            BlackMana = new List<Mana>();
            BlueMana = new List<Mana>();
            ColorlessMana = new List<Mana>();
            GreenMana = new List<Mana>();
            RedMana = new List<Mana>();
            WhiteMana = new List<Mana>();
        }
        #endregion

        #region Methods
        public void Add(Mana mana)
        {
            switch (mana.Color)
            {
                case Colors.Black:
                    BlackMana.Add(mana);
                    break;
                case Colors.Blue:
                    BlueMana.Add(mana);
                    break;
                case Colors.Colorless:
                    ColorlessMana.Add(mana);
                    break;
                case Colors.Green:
                    GreenMana.Add(mana);
                    break;
                case Colors.Red:
                    RedMana.Add(mana);
                    break;
                case Colors.White:
                    WhiteMana.Add(mana);
                    break;
            }
        }
        public void Add(Colors color, int count)
        {
            Add(new Mana() { Color = color, Count = count });
        }
        public void EmptyManaPool()
        {
            BlackMana.Clear();
            BlueMana.Clear();
            ColorlessMana.Clear();
            GreenMana.Clear();
            RedMana.Clear();
            WhiteMana.Clear();
        }
        public Mana FindMana(Guid manaId)
        {
            Mana retVal = BlackMana.FirstOrDefault(o=>o.Id == manaId);
            if (retVal != null)
                return retVal;
            retVal = BlueMana.FirstOrDefault(o => o.Id == manaId);
            if (retVal != null)
                return retVal;
            retVal = ColorlessMana.FirstOrDefault(o => o.Id == manaId);
            if (retVal != null)
                return retVal;
            retVal = GreenMana.FirstOrDefault(o => o.Id == manaId);
            if (retVal != null)
                return retVal;
            retVal = RedMana.FirstOrDefault(o => o.Id == manaId);
            if (retVal != null)
                return retVal;
            retVal = WhiteMana.FirstOrDefault(o => o.Id == manaId);
            return retVal;
        }
        private void Remove(Mana mana)
        {
            if (mana == null) return;
            switch (mana.Color)
            {
                case Colors.Black:
                    BlackMana.Remove(mana);
                    break;
                case Colors.Blue:
                    BlueMana.Remove(mana);
                    break;
                case Colors.Colorless:
                    ColorlessMana.Remove(mana);
                    break;
                case Colors.Green:
                    GreenMana.Remove(mana);
                    break;
                case Colors.Red:
                    RedMana.Remove(mana);
                    break;
                case Colors.White:
                    WhiteMana.Remove(mana);
                    break;
            }
        }
        public void UseMana(List<Guid> usedMana)
        {
            foreach (Guid id in usedMana)
                Remove(FindMana(id));
        }
        #endregion
    }
}