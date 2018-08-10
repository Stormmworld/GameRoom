using MTG.Interfaces;
using MTG.Enumerations;
using System;
using MTG.Model.Objects;
using System.Collections.Generic;
using MTG.Model.Effects;
using MTG.ArgumentDefintions.ActivationArguments;
using MTG.ArgumentDefintions.Event_Arguments;

namespace MTG.Model.Abilities
{
    public class ManaSource : IActivatedAbility
    {
        /*
        * https://mtg.gamepedia.com/ManaSource
             
        */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger;
        #endregion

        #region Variables
        private List<Mana> _ManaProduction;
        #endregion

        #region Properties
        public CastingCost ActivationCost { get; private set; }
        public Guid Id { get; private set; }
        public CardType CardTypeMultiplier { get; private set; }
        public IReadOnlyCollection<Mana> ManaProduction { get { return _ManaProduction.AsReadOnly(); } }
        #endregion

        #region Constructors
        private ManaSource()
        {
            ActivationCost = new CastingCost();
        }
        public ManaSource(Mana mana):this()
        {
            Id = Guid.NewGuid();
            _ManaProduction = new List<Mana>();
            _ManaProduction.Add(mana);
        }
        public ManaSource(Mana mana, CardType cardTypeMultiplier):this(mana)
        {
            CardTypeMultiplier = cardTypeMultiplier;
        }
        #endregion

        #region Methods
        public bool Activate(IActivationArgs e)
        {
            ManaSourceActivationArgs args = (ManaSourceActivationArgs)e;
            foreach (Mana mana in ManaProduction)
            {
                if (CardTypeMultiplier != CardType.None)
                    mana.Count = mana.Count * args.CardTypeCount;
                if (args.ManaMultiplier > 0)
                    mana.Count = mana.Count * args.ManaMultiplier;
                OnEffectTriggered?.Invoke(this, new EffectTriggeredEventArgs() { Effect = new AddManaToPoolEffect(mana, args.ActivatingPlayerId) });
            }
            return true;
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
        #endregion
    }
}
