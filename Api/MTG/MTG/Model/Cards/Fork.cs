using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Fork : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=200
        *  
        *  Copy target instant or sorcery spell, except that the copy is red. You may choose new targets for the copy.
        *  
        * Rulings
        * 2004-10-04: When a spell with additional costs is copied, you don't have to pay those costs again.
        * 2004-10-04: For spells that can have a variable number of targets, the controller of the copy must use the same number of targets the original spell did.
        * 2004-10-04: Forking a spell with an X in the cost requires you to use the same X value.
        * 2004-10-04: Fork will not copy changes made by modifying effects to the spell prior to the use of Fork, such as text-changing effects.
        * 2004-10-04: If mana or other costs need to be spent at resolution of the spell, the player of Fork would still be responsible for paying that cost.
        * 2004-10-04: You need not (and may not) pay any additional mana or other costs (like sacrifices) to use the spell which is Forked. You get control over a complete copy but can change nothing except the targets.
        * 2004-10-04: Fork does not let you make non-targeting choices about the spell.
        * 2004-10-04: If the spell being copied targets a spell on the stack, it is possible to target Fork itself since Fork is still on the stack when you pick the target(s) for the copy. Note that the copy's target will be illegal when it resolves.
        * 2004-10-04: If you copy a spell for which Buyback has been paid, you get nothing back since the copied spell does not have a card to give you.
        * 2004-10-04: The copy that is placed on the stack is not considered to have been "cast".
        * 2004-10-04: The Fork card goes to the graveyard when it resolves and leaves the copy on the stack. There is no card representing the copy on the stack.
        * 2004-10-04: It does copy the mana symbols in the mana cost for the card it is copying, but it uses its own color definition and not the one from those mana symbols. This is so it maintains its color just like the text says.
        * 2004-12-01: If you Fork a Spliced spell, the spliced text is added during the announcement of the original spell, and therefore is fully copied by Fork.
        * 2009-05-01: The copy will have the same mana cost as the original spell, but will be red rather than whatever color that mana cost would have made it.
        * 2009-10-01: If the targeted spell was kicked, then the copy will be kicked as well. If the targeted spell was not kicked, then the copy will not be kicked.

        *
        */
        public Fork() : base()
        {
            MultiverseId = 200;
            Name = "Fork";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            abilityCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(CardType.Instant);

            throw new NotImplementedException("Fork");
        }
        public Fork(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
