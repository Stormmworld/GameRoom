using MTG.Enumerations;
using MTG.Interfaces;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Effects
{
    public class AddManaToPoolEffect : IEffect
    {
        /*
         * AddManaToPool
         */
        #region Properties
        public GamePhases EndingPhase { get; private set; }
        public Mana Mana { get; private set; }
        public Target Target { get; private set; }
        public EffectTypes Type { get; private set; }
        public int Value { get; private set; }
        #endregion

        #region Constructors
        public AddManaToPoolEffect(Mana mana, Guid targetPlayerId)
        {
            EndingPhase = GamePhases.None;
            Type = EffectTypes.AddManaToPool;
            Mana = mana;
            Target = new Target() { Id = targetPlayerId, Type = TargetType.Player };
        }
        #endregion

        #region Methods
        #endregion
    }
}
