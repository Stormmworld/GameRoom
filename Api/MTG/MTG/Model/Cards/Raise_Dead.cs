using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Raise_Dead : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=78
        *  
        *  Return target creature card from your graveyard to your hand.
        *  
        * Rulings
        * 2004-10-04: You must show the card you bring out of the graveyard to your opponent.
        * 2004-10-04: The creature being brought back is chosen on announcement and not on resolution of the spell because it is targeted.
        * 2008-04-01: A "creature card" is any card with the type creature, even if it has other types such as artifact, enchantment, or land. Older cards of type summon are also creature cards.

        *
        */
        public Raise_Dead() : base()
        {
            MultiverseId = 78;
            Name = "Raise Dead";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(CardType.Sorcery);

            throw new NotImplementedException("Raise Dead");
        }
        public Raise_Dead(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
