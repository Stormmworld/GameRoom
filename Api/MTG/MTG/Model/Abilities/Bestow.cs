using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;


namespace MTG.Model.Abilities
{
    public class Bestow : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Bestow
            702.102a Bestow represents two static abilities, one that functions while the card with bestow is on the 
                    stack and another that functions both while it’s on the stack and while it’s on the battlefield. 
                    “Bestow [cost]” means “You may cast this card by paying [cost] rather than its mana cost.” and 
                    “If you chose to pay this spell’s bestow cost, it becomes an Aura enchantment and gains enchant 
                    creature. These effects last until one of two things happens: this spell has an illegal target as 
                    it resolves or the permanent this spell becomes, becomes unattached.” Paying a card’s bestow 
                    cost follows the rules for paying alternative costs in rules 601.2b and 601.2f–h.
            702.102b If a spell’s controller chooses to pay its bestow cost, that player chooses a legal target for 
                    that Aura spell as defined by its enchant creature ability and rule 601.2c. See also rule 303.4.
            702.102c The check for whether a spell can legally be cast happens after its controller has chosen whether 
                    to pay its bestow cost; see rule 601.2e.
                Example: Aether Storm is an enchantment with the ability “Creature spells can’t be cast.” This effect 
                        doesn’t stop a creature card with bestow from being cast for its bestow cost because the spell 
                        is an Aura enchantment spell, not an enchantment creature spell, when the game checks whether 
                        the spell is illegal.
            702.102d As an Aura spell with bestow begins resolving, if its target is illegal, the effect making it an 
                    Aura spell ends. It continues resolving as a creature spell and will be put onto the battlefield 
                    under the control of the spell’s controller. This is an exception to rule 608.3a.
            702.102e If an Aura with bestow is attached to an illegal object or player, it becomes unattached. This 
                    is an exception to rule 704.5m.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Bestow.Process");
        }
    }
}
