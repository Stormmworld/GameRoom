using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Stream_of_Life : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=173
        *  
        *  Target player gains X life.
        *  
        * Rulings

        *
        */
        public Stream_of_Life() : base()
        {
            MultiverseId = 173;
            Name = "Stream of Life";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, true)));
            abilityCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(CardType.Sorcery);

            throw new NotImplementedException("Stream of Life");
        }
        public Stream_of_Life(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
