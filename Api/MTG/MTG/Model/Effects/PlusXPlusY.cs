using MTG.Enumerations;
using MTG.Interfaces;
using MTG.Model.Objects;
using System;
using System.Collections.Generic;

namespace MTG.Model.Effects
{
    public class PlusXPlusY : IEffect
    {
        /*
         * PlusXPlusY
         */
        #region Properties
        public Guid BoundCardId { get; private set; }
        public GamePhases EndingPhase { get; private set; }
        public Guid EndingPhaseOwnerId { get; set; }
        public Target Target { get; set; }
        public TargetScope TargetScope { get; private set; }
        public List<TargetType> TargetTypes { get; private set; }
        public List<Colors> TargetColors { get; private set; }
        public int Value { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }
        #endregion

        #region Constructors
        private PlusXPlusY()
        {
            TargetColors = new List<Colors>();
            TargetTypes = new List<TargetType>();
        }
        public PlusXPlusY(Guid boundCardId, int x, int y, TargetScope targetScope, List<TargetType> targetTypes, List<Colors> targetColors) :this()
        {
            BoundCardId = boundCardId;
            X = x;
            Y = y;
            TargetScope = targetScope;
            TargetColors.AddRange(targetColors);
            TargetTypes.AddRange(targetTypes);
        }
        #endregion
    }
}
