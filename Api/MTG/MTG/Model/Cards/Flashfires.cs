using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Flashfires : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=199
        *  
        *  Destroy all Plains.
        *  
        * Rulings

        *
        */
        public Flashfires() : base()
        {
            MultiverseId = 199;
            Name = "Flashfires";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            abilityCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(CardType.Sorcery);

            throw new NotImplementedException("Flashfires");
        }
        public Flashfires(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
