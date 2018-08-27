using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Tunnel : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=226
        *  
        *  Destroy target Wall. It can't be regenerated.
        *  
        * Rulings

        *
        */
        public Tunnel() : base()
        {
            MultiverseId = 226;
            Name = "Tunnel";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(CardType.Instant);

            throw new NotImplementedException("Tunnel");
        }
        public Tunnel(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
