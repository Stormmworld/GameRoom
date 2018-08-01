using MTG.Interfaces;
using MTG.ArgumentDefintions;
using MTG.Enumerations;
using System;
using System.Collections.Generic;

namespace MTG.Model.Abilities
{ 
    public class Phasing : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Phasing
            702.25a Phasing is a static ability that modifies the rules of the untap step. During each player’s 
                    untap step, before the active player untaps permanents, all phased-in permanents with phasing 
                    that player controls “phase out.” Simultaneously, all phased-out permanents that had phased 
                    out under that player’s control “phase in.”
            702.25b If a permanent phases out, its status changes to “phased out.” Except for rules and effects 
                    that specifically mention phased-out permanents, a phased-out permanent is treated as though 
                    it does not exist. It can’t affect or be affected by anything else in the game. A permanent 
                    that phases out is removed from combat. (See rule 506.4.)
                Example: You control three creatures, one of which is phased out. You cast a spell that says 
                        “Draw a card for each creature you control.” You draw two cards.
                Example: You control a phased-out creature. You cast a spell that says “Destroy all creatures.” 
                        The phased-out creature is not destroyed.
            702.25c If a permanent phases in, its status changes to “phased in.” The game once again treats it as 
                    though it exists.
            702.25d The phasing event doesn’t actually cause a permanent to change zones or control, even though 
                    it’s treated as though it’s not on the battlefield and not under its controller’s control while 
                    it’s phased out. Zone-change triggers don’t trigger when a permanent phases in or out. Tokens 
                    continue to exist on the battlefield while phased out. Counters remain on a permanent while 
                    it’s phased out. Effects that check a phased-in permanent’s history won’t treat the phasing 
                    event as having caused the permanent to leave or enter the battlefield or its controller’s 
                    control.
            702.25e Continuous effects that affect a phased-out permanent may expire while that permanent is 
                    phased out. If so, they will no longer affect that permanent once it’s phased in. In particular, 
                    effects with “for as long as” durations that track that permanent (see rule 611.2b) end when that 
                    permanent phases out because they can no longer see it.
            702.25f When a permanent phases out, any Auras, Equipment, or Fortifications attached to that permanent 
                    phase out at the same time. This alternate way of phasing out is known as phasing out “indirectly.” 
                    An Aura, Equipment, or Fortification that phased out indirectly won’t phase in by itself, but 
                    instead phases in along with the permanent it’s attached to.
            702.25g If an object would simultaneously phase out directly and indirectly, it just phases out indirectly.
            702.25h An Aura, Equipment, or Fortification that phased out directly will phase in attached to the object 
                    or player it was attached to when it phased out, if that object is still in the same zone or that 
                    player is still in the game. If not, that Aura, Equipment, or Fortification phases in unattached. 
                    State-based actions apply as appropriate. (See rules 704.5m and 704.5n.)
            702.25i Abilities that trigger when a permanent becomes attached or unattached from an object or player 
                    don’t trigger when that permanent phases in or out.
            702.25j Phased-out permanents owned by a player who leaves the game also leave the game. This doesn’t 
                    trigger zone-change triggers. See rule 800.4.
            702.25k If an effect causes a player to skip their untap step, the phasing event simply doesn’t occur 
                    that turn.
            702.25m In a multiplayer game, game rules may cause a phased-out permanent to leave the game or to be 
                    exiled once a player leaves the game. (See rules 800.4a and 800.4c.) If a phased-out permanent 
                    phased out under the control of a player who has left the game, that permanent phases in during 
                    the next untap step after that player’s next turn would have begun.
            702.25n Multiple instances of phasing on the same permanent are redundant.
        */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger;
        #endregion

        #region Variables
        private List<AbilityType> _Types;
        #endregion

        #region Properties
        public EffectTrigger Trigger { get { return EffectTrigger.Phases_BegginingPhase_UntapStep; } }
        public IReadOnlyCollection<AbilityType> Types { get { return _Types.AsReadOnly(); } }
        #endregion

        #region Constructors
        public Phasing()
        {
            _Types = new List<AbilityType>();
            _Types.Add(AbilityType.Triggered);
                    throw new NotImplementedException("Phasing.Constructor");
        }
        #endregion

        #region Methods
        public void Process(AbilityArgs args)
        {
            args.OriginCard.PhasedOut = !args.OriginCard.PhasedOut;
        }
        #endregion
    }
}
