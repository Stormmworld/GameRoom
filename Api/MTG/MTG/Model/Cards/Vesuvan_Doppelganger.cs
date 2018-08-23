using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Vesuvan_Doppelganger : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=135
            *  
            *  You may have Vesuvan Doppelganger enter the battlefield as a copy of any creature on the battlefield, except it doesn't copy that creature's color and it gains "At the beginning of your upkeep, you may have this creature become a copy of target creature except it doesn't copy that creature's color. If you do, this creature gains this ability."
            *  
            * Rulings
		2004-10-04: When the Doppelganger switches creatures, the creature it used to be is not considered to have left the battlefield. Such effects will consider the creature to have left the battlefield when the Doppelganger leaves the battlefield.
		2004-10-04: Damage is not removed when it changes forms.
		2004-10-04: Can switch to the same creature it is currently a copy of.
		2004-10-04: When it takes on the characteristics of the other card, it is no longer of creature type Shapeshifter.
		2004-10-04: When changing forms, any text changes that exist on the Doppelganger are applied to the new text, if appropriate.
		2004-12-01: If a Doppelganger is flipped, and it copies a flip card in any state, it will copy both "sides" of that card but use the flipped side. If a Doppelganger is unflipped, and it copies a flip card in any state, it will copy both "sides" of that card but use the unflipped side. In the second case, if it ever meets the flip conditions of its new ability, it will flip and used the flipped side of what it is copying.
		2007-09-16: When Vesuvan Doppelganger's triggered ability triggers, you must choose a target for it. You determine whether to have the Doppelganger become a copy of that target when the ability resolves.
		2007-09-16: Vesuvan Doppelganger copies the mana cost of the creature it's copying but doesn't copy its color.
		2007-09-16: If another creature copies Vesuvan Doppelganger, the new creature will become a copy of whatever Vesuvan Doppelganger is copying except for its color, will copy Vesuvan Doppelganger's color, and will gain Vesuvan Doppelganger's triggered ability.
		2007-09-16: Vesuvan Doppelganger's triggered ability may cause it to become a copy of itself. A Vesuvan Doppelganger that becomes a copy of a Vesuvan Doppelganger (either itself or a different one) will gain another instance of its triggered ability. Each instance of that ability will trigger during its controller's upkeep. They'll all be put on the stack and resolve one at a time. The last one to resolve determines the Doppelganger's characteristics for the rest of the turn.
		2007-09-16: Vesuvan Doppelganger copies a face-down creature, it becomes a face-up 2/2 blue creature with no name and no abilities other than the one it gives itself.
		2007-09-16: Although Vesuvan Doppelganger's triggered ability is targeted, its "as enters the battlefield" ability is not.

            *  
            */
        public Vesuvan_Doppelganger() : base()
        {
            MultiverseId = 135;
            Name = "Vesuvan Doppelganger";
	Add(Enumerations.Colors.Blue);
	Add(Enumerations.SubType.Shapeshifter);
	Add(Enumerations.CardType.Creature);
	_Power = 0;
		_Toughness = 0;

            throw new NotImplementedException("Vesuvan Doppelganger");
        }
        public Vesuvan_Doppelganger(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
