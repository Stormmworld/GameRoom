using MTG.Interfaces.Ability_Interfaces;
using System;

namespace MTG.Model.Abilities.Static
{ 
    public class Banding : IStaticAbility
    {
        /* Rules
         * https://mtg.gamepedia.com/Banding
            702.21. Banding
            702.21a Banding is a static ability that modifies the rules for combat.
            702.21b “Bands with other” is a special form of banding. If an effect causes a 
                    permanent to lose banding, the permanent loses all “bands with other” 
                    abilities as well.
            702.21c As a player declares attackers, they may declare that one or more 
                    attacking creatures with banding and up to one attacking creature 
                    without banding (even if it has “bands with other”) are all in a 
                    “band.” They may also declare that one or more attacking [quality] 
                    creatures with “bands with other [quality]” and any number of 
                    other attacking [quality] creatures are all in a band. A player may 
                    declare as many attacking bands as they want, but each creature may 
                    be a member of only one of them. (Defending players can’t declare 
                    bands but may use banding in a different way; see rule 702.21j.)
            702.21d All creatures in an attacking band must attack the same player or 
                    planeswalker.
            702.21e Once an attacking band has been announced, it lasts for the rest of 
                    combat, even if something later removes banding or “bands with other” 
                    from one or more of the creatures in the band.
            702.21f An attacking creature that’s removed from combat is also removed 
                    from the band it was in.
            702.21g Banding doesn’t cause attacking creatures to share abilities, 
                    nor does it remove any abilities. The attacking creatures in a band 
                    are separate permanents.
            702.21h If an attacking creature becomes blocked by a creature, each other 
                    creature in the same band as the attacking creature becomes blocked 
                    by that same blocking creature.
                    Example: A player attacks with a band consisting of a creature with 
                             flying and a creature with swampwalk. The defending player, 
                             who controls a Swamp, can block the flying creature if able. 
                             If they do, then the creature with swampwalk will also become 
                             blocked by the blocking creature(s).                
            702.21i If one member of a band would become blocked due to an effect, 
                    the entire band becomes blocked.
            702.21j During the combat damage step, if an attacking creature is being blocked 
                    by a creature with banding, or by both a [quality] creature with 
                    “bands with other [quality]” and another [quality] creature, the defending 
                    player (rather than the active player) chooses how the attacking creature’s 
                    damage is assigned. That player can divide that creature’s combat damage as 
                    they choose among any number of creatures blocking it. This is an exception 
                    to the procedure described in rule 510.1c.
            702.21k During the combat damage step, if a blocking creature is blocking a creature 
                    with banding, or both a [quality] creature with “bands with other [quality]” 
                    and another [quality] creature, the active player (rather than the defending player)
                    chooses how the blocking creature’s damage is assigned. That player can divide that 
                    creature’s combat damage as they choose among any number of creatures it’s blocking. 
                    This is an exception to the procedure described in rule 510.1d.
            702.21m Multiple instances of banding on the same creature are redundant. Multiple instances 
                    of “bands with other” of the same kind on the same creature are redundant.
         */

        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger, OnCardEvent;
        #endregion

        #region Properties
        public Guid Id { get; private set; }
        #endregion

        #region Constructors
        public Banding()
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
