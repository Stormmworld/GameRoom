﻿using System;
using System.Collections.Generic;
using System.Linq;
using MTG.Interfaces.Card_Interfaces;
using MTG.Interfaces.Game_Interfaces;

namespace MTG.Model.Zones._Base
{
    public class Zone : IZone
    {
        #region Events
        public event EventHandler OnAddCardToZone, OnCardEvent;
        #endregion

        #region Variables
        private List<ICard> _Cards;
        #endregion

        #region Collection Properties
        public IReadOnlyCollection<ICard> Cards { get { return _Cards.AsReadOnly(); } }
        #endregion

        #region Properties
        #endregion

        #region Constructors
        internal Zone()
        {
        }
        #endregion

        #region Methods
        public void Add(ICard card)
        {
            throw new NotImplementedException();
        }
        public void Add(List<ICard> cards)
        {
            throw new NotImplementedException();
        }
        public List<ICard> Find(Predicate<ICard> predicate)
        {
            throw new NotImplementedException();
        }
        public List<ICard> Find(Predicate<ICreature> predicate)
        {
            throw new NotImplementedException();
        }
        public List<ICard> Find(Predicate<ISpell> predicate)
        {
            throw new NotImplementedException();
        }
        public List<ICard> Find(Predicate<IPermanent> predicate)
        {
            throw new NotImplementedException();
        }
        public void Remove(Guid cardId)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return GetType().Name;
        }
        #endregion
    }
}
