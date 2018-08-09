using MTG.Interfaces;
using MTG.ArgumentDefintions;
using MTG.Enumerations;
using System;
using MTG.Model.Objects;
using System.Collections.Generic;
using MTG.Model.Effects;

namespace MTG.Model.Abilities
{
    public class ManaSource : IAbility
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
        public CardType CardTypeMultiplier { get; private set; }
        public IReadOnlyCollection<Mana> ManaProduction { get { return _ManaProduction.AsReadOnly(); } }
        public EffectTrigger Trigger { get { return EffectTrigger.Card_Tapping; } }
        public AbilityType Type { get { return AbilityType.Activated; } }
        #endregion

        #region Constructors
        public ManaSource(Mana mana)
        {
            _ManaProduction = new List<Mana>();
            _ManaProduction.Add(mana);
        }
        public ManaSource(Mana mana, CardType cardTypeMultiplier):this(mana)
        {
            CardTypeMultiplier = cardTypeMultiplier;
        }
        #endregion

        #region Methods
        public void Process(AbilityArgs args)
        {
            foreach (Mana mana in ManaProduction)
            {
                if (CardTypeMultiplier != CardType.None)
                    mana.Count = mana.Count * args.CardTypeCount;
                if (args.ManaMultiplier > 0)
                    mana.Count = mana.Count * args.ManaMultiplier;
                OnEffectTriggered?.Invoke(this, new EffectTriggeredEventArgs() { Effect = new AddManaToPoolEffect(mana, args.TargetPlayer.Id) });
            }
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
        #endregion
    }
}
