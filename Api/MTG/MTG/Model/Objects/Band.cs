﻿using MTG.Enumerations;
using MTG.Model.Abilities;
using MTG.Model.Objects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MTG.Model.Objects
{
    public class Band
    {
        #region Rules
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
        #endregion

        #region Variables
        private List<Card> _BandMembers;
        #endregion

        #region Properties
        public BandTypes BandType { get; private set; }
        public IReadOnlyCollection<Card> BandMembers { get { return _BandMembers.AsReadOnly(); } }
        public Blocker Blocker { get; set; }
        public Guid Id { get; set; }
        #endregion

        #region Constructors
        public Band(BandTypes bandType)
        {
            Id = Guid.NewGuid();
            BandType = bandType;
            Blocker = new Blocker();
            _BandMembers = new List<Card>();
        }
        #endregion

        #region Methods
        public void AddBlocker(Card card, Guid bandId)
        {
            if (BandType != BandTypes.Attacking)
                throw new Exception("Band.AddBlocker: Cannot add a blocker to a band that is not attacking");
            Blocker.Add(card, bandId);
        }
        public void AddMember(Card member)
        {
            #region Rules
            /*
            702.21c As a player declares attackers, they may declare that one or more
                    attacking creatures with banding and up to one attacking creature
                    without banding(even if it has “bands with other”) are all in a
                    “band.” They may also declare that one or more attacking[quality]
                    creatures with “bands with other[quality]” and any number of
                    other attacking[quality] creatures are all in a band. A player may
                    declare as many attacking bands as they want, but each creature may
                    be a member of only one of them. (Defending players can’t declare
                    bands but may use banding in a different way; see rule 702.21j.)
            */
            #endregion
            if (member.HasAbility(typeof(Banding)))
                _BandMembers.Add(member);
            else if (_BandMembers.FirstOrDefault(o=>!o.HasAbility(typeof(Banding))) != null)
                _BandMembers.Add(member);
            else
                throw new Exception("Band.AddMember:(Rule 702.21c) Cannot add another member without the banding ability.");
        }
        public void AssignDamage(bool isFirstStrike)
        {
            throw new NotImplementedException("Band.AssignDamage");
        }
        public bool HasAbility(Type abilityType)
        {
            throw new NotImplementedException("Band.HasAbility");
        }
        public void CommitDamage(DamageSelection selections = null)
        {
            if (selections == null)
            {//create pending Damage Selection Event
                throw new NotImplementedException("Band.ProcessDamage - Unselected");
            }
            else
            {//Process Damage Selections
                throw new NotImplementedException("Band.ProcessDamage - Selected");
            }
        }
        #endregion
    }
}