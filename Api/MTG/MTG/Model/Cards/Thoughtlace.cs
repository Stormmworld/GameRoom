using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Thoughtlace : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=130
        *  
        *  Target spell or permanent becomes blue. (Mana symbols on that permanent remain unchanged.)
        *  
        * Rulings

        *
        */
        public Thoughtlace() : base()
        {
            MultiverseId = 130;
            Name = "Thoughtlace";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(CardType.Instant);

            throw new NotImplementedException("Thoughtlace");
        }
        public Thoughtlace(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
