using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Tsunami : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=177
        *  
        *  Destroy all Islands.
        *  
        * Rulings

        *
        */
        public Tsunami() : base()
        {
            MultiverseId = 177;
            Name = "Tsunami";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            abilityCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(CardType.Sorcery);

            throw new NotImplementedException("Tsunami");
        }
        public Tsunami(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
