using MTG.Enumerations;
using MTG.Model.Objects;
using System;
using System.Collections.Generic;

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
        public void AddMana(Mana mana)
        {
            throw new NotImplementedException("ManaPool.AddMana");
        }
        public void AddMana(Colors color, int count)
        {
            AddMana(new Mana() { Color = color, Count = count });
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
        public void UseMana(Colors color, int count, bool activatingAbility, Card cardConsumingMana)
        {
            throw new NotImplementedException("ManaPool.UseMana");
        }
        #endregion
    }
}