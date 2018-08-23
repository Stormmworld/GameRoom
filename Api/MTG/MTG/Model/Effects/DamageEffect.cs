﻿using MTG.Enumerations;
using MTG.Interfaces;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Effects
{
    public class DamageEffect : IEffect
    {
        /*
         * DamageEffect
         */
        #region Properties
        public Guid BoundCardId { get; private set; }
        public GamePhases EndingPhase { get; private set; }
        public Guid EndingPhaseOwnerId { get; set; }
        public Target Target { get; private set; }
        public Damage Damage { get; private set; }
        #endregion

        #region Constructors
        public DamageEffect(Damage damage, Target target)
        {
            EndingPhase = GamePhases.None;
            EndingPhaseOwnerId  = new Guid();
            Target = target;
            Damage = damage;
        }
        #endregion
    }
}
