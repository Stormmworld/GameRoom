using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Purelace : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=263
        *  
        *  Target spell or permanent becomes white. (Mana symbols on that permanent remain unchanged.)
        *  
        * Rulings

        *
        */
        public Purelace() : base()
        {
            MultiverseId = 263;
            Name = "Purelace";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(CardType.Instant);

            throw new NotImplementedException("Purelace");
        }
        public Purelace(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
