using MTG.Enumerations;
using MTG.Interfaces;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Effects
{
    public class CardsFromZoneToZone : IEffect
    {
        /*
         * CardsFromZoneToZone
         */
        #region Properties
        public IZone DestinationZone { get; private set; }
        public GamePhases EndingPhase { get; private set; }
        public Guid EndingPhaseOwnerId { get; set; }
        public IZone OriginZone { get; private set; }
        public Target Target { get; private set; }
        public int Value { get; private set; }
        #endregion

        #region Constructors
        public CardsFromZoneToZone(Target target, IZone originZone, IZone destinationZone)
        {
            Target = target;
            OriginZone = originZone;
            DestinationZone = destinationZone;
        }
        #endregion
    }
}
