using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Nightmare : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=74
        *  
        *  Flying (This creature can't be blocked except by creatures with flying or reach.)
Nightmare's power and toughness are each equal to the number of Swamps you control.
        *  
        * Rulings
        * 2008-04-01: If you control 0 swamps, then the Nightmare has 0 toughness and will be put into its owner's graveyard as a state-based action right before the next player gains priority.
        * 2009-10-01: Nightmare's power and toughness changes as the number of Swamps you control changes.
        * 2013-07-01: The ability that defines Nightmare's power and toughness works everywhere, not just on the battlefield.
        * 2013-07-01: Nightmare's ability counts all lands you control with the subtype Swamp, not just ones named Swamp.

        *
        */
        public Nightmare() : base()
        {
            MultiverseId = 74;
            Name = "Nightmare";
            //Set(*, *);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 5)));
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(SubType.Nightmare);
            Add(SubType.Horse);
            Add(CardType.Creature);

            throw new NotImplementedException("Nightmare");
        }
        public Nightmare(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
