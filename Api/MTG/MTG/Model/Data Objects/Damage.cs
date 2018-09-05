using System;
using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Interfaces.Card_Interfaces;
using MTG.Interfaces.Data_Interfaces;
using MTG.Interfaces.Effect_Interfaces;

namespace MTG.Model.Data_Objects
{
    public class Damage : IDamage
    {
        #region Variables
        private List<CardType>  _CardTypes;
        private List<Color>     _Colors;
        private List<SubType>   _SubTypes;
        private List<SuperType> _SuperTypes;
        #endregion

        #region Collection Properties
        public IReadOnlyList<CardType> CardTypes { get { return _CardTypes.AsReadOnly(); } }
        public IReadOnlyList<Color> Colors { get { return _Colors.AsReadOnly(); } }
        public IReadOnlyList<SubType> SubTypes { get { return _SubTypes.AsReadOnly(); } }
        public IReadOnlyList<SuperType> SuperTypes { get { return _SuperTypes.AsReadOnly(); } }
        #endregion

        #region Properties
        public Guid Id { get; private set; }
        public int Modifier { get; private set; }
        public IEffect OnDamagePlayerEffect { get; internal set; }
        public bool OnDamageOpponent { get; internal set; }
        public bool UseXValue { get; private set; }
        public int Value { get; private set; }
        public Modifier XModifier { get; private set; }
        #endregion

        #region Constructors
        private Damage()
        {
            Id = Guid.NewGuid();
            _CardTypes= new List<CardType>();
            _Colors= new List<Color>();
            _SubTypes = new List<SubType>();
            _SuperTypes= new List<SuperType>();
        }
        public Damage(ICard originCard, int value):this()
        {
            _CardTypes.AddRange(originCard.CardTypes);
            _Colors.AddRange(originCard.Colors);
            _SubTypes.AddRange(originCard.SubTypes);
            _SuperTypes.AddRange(originCard.SuperTypes);
            Value = value;
        }
        public Damage(ICard originCard, Modifier xModifier) : this(originCard, 0)
        {
            UseXValue = true;
            XModifier = xModifier;
        }
        #endregion

        #region Methods
        public void Add(CardType cardType)
        {
            throw new NotImplementedException();
        }
        public void Add(Color color)
        {
            throw new NotImplementedException();
        }
        public void Add(int Modifier)
        {
            throw new NotImplementedException();
        }
        public void Add(SubType subType)
        {
            throw new NotImplementedException();
        }
        public void Add(SuperType superType)
        {
            throw new NotImplementedException();
        }
        public void Assign(ICard card)
        {
            throw new NotImplementedException();
        }
        public void Has(CardType cardType)
        {
            throw new NotImplementedException();
        }
        public void Has(Color color)
        {
            throw new NotImplementedException();
        }
        public void Has(SubType subType)
        {
            throw new NotImplementedException();
        }
        public void Has(SuperType superType)
        {
            throw new NotImplementedException();
        }
        public void Remove(CardType cardType)
        {
            throw new NotImplementedException();
        }
        public void Remove(Color color)
        {
            throw new NotImplementedException();
        }
        public void Remove(SubType subType)
        {
            throw new NotImplementedException();
        }
        public void Remove(SuperType superType)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
