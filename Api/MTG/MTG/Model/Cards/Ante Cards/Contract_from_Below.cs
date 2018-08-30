using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Contract_from_Below : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=52
        *  
        *  Remove Contract from Below from your deck before playing if you're not playing for ante.
        *  Discard your hand, ante the top card of your library, then draw seven cards.
        *  
        * Rulings
        *
        */
        public Contract_from_Below() : base()
        {
            MultiverseId = 52;
            Name = "Contract from Below";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(CardType.Sorcery);

            throw new NotImplementedException("Contract from Below");
        }
        public Contract_from_Below(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
