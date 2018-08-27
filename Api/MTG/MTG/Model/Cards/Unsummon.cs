using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Unsummon : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=134
        *  
        *  Return target creature to its owner's hand.
        *  
        * Rulings

        *
        */
        public Unsummon() : base()
        {
            MultiverseId = 134;
            Name = "Unsummon";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(CardType.Instant);

            throw new NotImplementedException("Unsummon");
        }
        public Unsummon(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
