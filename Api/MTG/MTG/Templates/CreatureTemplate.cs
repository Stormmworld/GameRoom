using MTG.ArgumentDefintions.Event_Arguments;
using MTG.Enumerations;
using MTG.Interfaces;
using MTG.Interfaces.Card_Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTG.Templates
{
    public class CreatureTemplate : ICreature
    {
        #region Events
        public event EventHandler OnCardEvent, OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger;
        #endregion

        #region Variables
        private List<IAbility> _Abilities;
        private List<Colors> _Colors;
        private List<int> _Damage;
        private List<SubType> _SubTypes;
        private List<SuperType> _SuperTypes;
        private List<CardType> _Types;
        #endregion

        #region Collection Properties
        public IReadOnlyList<IAbility> Abilities { get { return _Abilities.AsReadOnly(); } }
        public IReadOnlyList<Colors> Colors { get { return _Colors.AsReadOnly(); } }
        public IReadOnlyList<int> Damage { get { return _Damage.AsReadOnly(); } }
        public IReadOnlyList<SubType> SubTypes { get { return _SubTypes.AsReadOnly(); } }
        public IReadOnlyList<SuperType> SuperTypes { get { return _SuperTypes.AsReadOnly(); } }
        public IReadOnlyList<CardType> Types { get { return _Types.AsReadOnly(); } }
        #endregion

        #region Properties
        public Guid ControllerId => throw new NotImplementedException();
        public Guid Id => throw new NotImplementedException();
        public string ImageUrl => throw new NotImplementedException();
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Guid OwnerId => throw new NotImplementedException();
        public int Power => throw new NotImplementedException();
        public bool Tapped => throw new NotImplementedException();
        public int Toughness => throw new NotImplementedException();
        #endregion

        #region Constructor
        #endregion

        #region Event Handlers
        public void Ability_OnCardEvent(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        public void Ability_OnEffectTrigger(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        public void Ability_OnEffectTriggered(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        public void Ability_OnPendingActionTriggered(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Interfacing Methods
        public void Add(IAbility ability)
        {
            throw new NotImplementedException();
        }
        public void Add(CardType cardType)
        {
            throw new NotImplementedException();
        }
        public void Add(Colors color)
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
        public void Apply(ApplyDamageEventArgs args)
        {
            throw new NotImplementedException();
        }
        public void Apply(ICardEventArgs args)
        {
            throw new NotImplementedException();
        }
        public void CheckTriggeredAbilities(EffectTrigger trigger, ITriggeredAbilityArgs args = null)
        {
            throw new NotImplementedException();
        }
        public void Destroy()
        {
            throw new NotImplementedException();
        }
        public bool Has(IAbility ability)
        {
            throw new NotImplementedException();
        }
        public bool Has(CardType cardType)
        {
            throw new NotImplementedException();
        }
        public bool Has(SubType subType)
        {
            throw new NotImplementedException();
        }
        public bool Has(SuperType superType)
        {
            throw new NotImplementedException();
        }
        public void Remove(IAbility ability)
        {
            throw new NotImplementedException();
        }
        public void Remove(CardType cardType)
        {
            throw new NotImplementedException();
        }
        public void Remove(Colors color)
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
        public void Resolve()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Internal Methods
        #endregion
    }
}
