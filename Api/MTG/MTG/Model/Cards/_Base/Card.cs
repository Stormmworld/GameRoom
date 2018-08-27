using System;
using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Interfaces.Argument_Interfaces;
using MTG.Interfaces.Card_Interfaces;
using MTG.Interfaces.Effect_Interfaces;
using MTG.Interfaces.Mana_Interfaces;

namespace MTG.Model.Cards._Base
{
    public class Card : ICard
    {
        #region Events
        public event EventHandler OnCardEvent, OnNewEffect, OnEvent;
        #endregion

        #region Variables
        private List<CardType> _CardTypes;
        private List<Color> _Colors;
        private List<IEffect> _Effects;
        private List<SubType> _SubTypes;
        private List<SuperType> _SuperTypes;
        #endregion

        #region Collection Properties
        public IReadOnlyList<CardType> CardTypes { get { return _CardTypes.AsReadOnly(); } }
        public IReadOnlyList<Color> Colors { get { return _Colors.AsReadOnly(); } }
        public IReadOnlyList<IEffect> Effects { get { return _Effects.AsReadOnly(); } }
        public IReadOnlyList<SubType> SubTypes { get { return _SubTypes.AsReadOnly(); } }
        public IReadOnlyList<SuperType> SuperTypes { get { return _SuperTypes.AsReadOnly(); } }
        #endregion

        #region Properties
        public ICastingCost CastingCost { get; internal set; }
        public Guid Id { get; private set; }
        public string ImageUrl { get { return "/" + MultiverseId; } }
        public int MultiverseId { get; internal set; }
        public string Name { get; internal set; }
        public Guid OwnerId { get; set; }
        #endregion

        #region Constructors
        internal Card()
        {
            Id = Guid.NewGuid();
            _CardTypes = new List<CardType>();
            _Colors = new List<Color>();
            _Effects = new List<IEffect>();
            _SubTypes = new List<SubType>();
            _SuperTypes = new List<SuperType>();
        }
        #endregion

        #region Event Handlers
        public virtual void Ability_NewEffect(object sender, EventArgs e)
        {
            OnNewEffect?.Invoke(sender, e);
        }
        public virtual void Ability_Event(object sender, EventArgs e)
        {
            OnEvent?.Invoke(sender, e);
        }
        #endregion

        #region Methods
        public virtual void Add(CardType cardType)
        {
            _CardTypes.Add(cardType);
        }
        public virtual void Add(Color color)
        {
            _Colors.Add(color);
        }
        public virtual void Add(IEffect effect)
        {
            _Effects.Add(effect);
        }
        public virtual void Add(SubType subType)
        {
            _SubTypes.Add(subType);
        }
        public virtual void Add(SuperType superType)
        {
            _SuperTypes.Add(superType);
        }
        public virtual void Apply(ICardArguments args)
        {
            throw new NotImplementedException("Card.Apply ICardEventArgs");
        }
        public virtual void Apply(EffectTrigger trigger, ITriggeredAbilityArguments args)
        {
            throw new NotImplementedException("Card.Apply EffectTrigger");
        }
        public virtual bool Has(CardType cardType)
        {
            return _CardTypes.Contains(cardType);
        }
        public virtual bool Has(Color color)
        {
            return _Colors.Contains(color);
        }
        public virtual bool Has(IEffect effect)
        {
            return _Effects.Contains(effect);
        }
        public virtual bool Has(SubType subType)
        {
            return _SubTypes.Contains(subType);
        }
        public virtual bool Has(SuperType superType)
        {
            return _SuperTypes.Contains(superType);
        }
        public virtual void Remove(CardType cardType)
        {
            _CardTypes.Remove(cardType);
        }
        public virtual void Remove(Color color)
        {
            _Colors.Remove(color);
        }
        public virtual void Remove(IEffect effect)
        {
            _Effects.Remove(effect);
        }
        public virtual void Remove(SubType subType)
        {
            _SubTypes.Remove(subType);
        }
        public virtual void Remove(SuperType superType)
        {
            _SuperTypes.Remove(superType);
        }
        public override string ToString()
        {
            return GetType().Name;
        }
        #endregion
    }
}
