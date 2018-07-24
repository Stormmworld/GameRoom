using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Splice : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Splice
            702.46a Splice is a static ability that functions while a card is in your hand. “Splice onto [subtype] [cost]”
                    means “You may reveal this card from your hand as you cast a [subtype] spell. If you do, copy this 
                    card’s text box onto that spell and pay [cost] as an additional cost to cast that spell.” Paying a 
                    card’s splice cost follows the rules for paying additional costs in rules 601.2b and 601.2f–h.
                Example: Since the card with splice remains in the player’s hand, it can later be cast normally or spliced 
                        onto another spell. It can even be discarded to pay a “discard a card” cost of the spell it’s spliced onto.
            702.46b You can’t choose to use a splice ability if you can’t make the required choices (targets, etc.) for 
                    that card’s instructions. You can’t splice any one card onto the same spell more than once. If you’re 
                    splicing more than one card onto a spell, reveal them all at once and choose the order in which their 
                    instructions will be followed. The instructions on the main spell have to be followed first.
            702.46c The spell has the characteristics of the main spell, plus the text boxes of each of the spliced cards. 
                    The spell doesn’t gain any other characteristics (name, mana cost, color, supertypes, card types, 
                    subtypes, etc.) of the spliced cards. Text copied onto the spell that refers to a card by name refers 
                    to the spell on the stack, not the card from which the text was copied.
                Example: Glacial Ray is a red card with splice onto Arcane that reads, “Glacial Ray deals 2 damage to any
                        target.” Suppose Glacial Ray is spliced onto Reach Through Mists, a blue spell. The spell is still
                        blue, and Reach Through Mists deals the damage. This means that the ability can target a creature 
                        with protection from red and deal 2 damage to that creature.
            702.46d Choose targets for the added text normally (see rule 601.2c). Note that a spell with one or more 
                    targets won’t resolve if all of its targets are illegal on resolution.
            702.46e The spell loses any splice changes once it leaves the stack for any reason.
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Splice.Process");
        }
    }
}
