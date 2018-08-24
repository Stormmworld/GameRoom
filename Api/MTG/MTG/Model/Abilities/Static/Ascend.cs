using MTG.Interfaces.Ability_Interfaces;
using System;

namespace MTG.Model.Abilities.Static
{ 
    public class Ascend : IStaticAbility
    {
        /*
             * https://mtg.gamepedia.com/Ascend
                702.130a Ascend on an instant or sorcery spell represents a spell ability. It means 
                        “If you control ten or more permanents and you don’t have the city’s blessing, 
                        you get the city’s blessing for the rest of the game.”
                702.130b Ascend on a permanent represents a static ability. It means “Any time you 
                        control ten or more permanents and you don’t have the city’s blessing, you 
                        get the city’s blessing for the rest of the game.”
                702.130c The city’s blessing is a designation that has no rules meaning other than 
                        to act as a marker that other rules and effects can identify. Any number 
                        of players may have the city’s blessing at the same time.
                702.130d After a player gets the city’s blessing, continuous effects are reapplied 
                        before the game checks to see if the game state or preceding events have 
                        matched any trigger conditions.
             */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger, OnCardEvent;
        #endregion

        #region Properties
        public Guid BoundCardId { get; set; }
        public Guid Id { get; private set; }
        #endregion

        #region Constructors
        public Ascend()
        {
            Id = Guid.NewGuid();
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return this.GetType().Name;
        }
        #endregion
    }
}
