using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Lifelace : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=163
        *  
        *  Target spell or permanent becomes green. (Mana symbols on that permanent remain unchanged.)
        *  
        * Rulings

        *
        */
        public Lifelace() : base()
        {
            MultiverseId = 163;
            Name = "Lifelace";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(CardType.Instant);

            throw new NotImplementedException("Lifelace");
        }
        public Lifelace(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
