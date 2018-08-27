using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Braingeyser : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=98
        *  
        *  Target player draws X cards.
        *  
        * Rulings

        *
        */
        public Braingeyser() : base()
        {
            MultiverseId = 98;
            Name = "Braingeyser";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, true)));
            abilityCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            abilityCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(CardType.Sorcery);

            throw new NotImplementedException("Braingeyser");
        }
        public Braingeyser(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
