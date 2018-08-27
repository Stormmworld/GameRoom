using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Resurrection : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=265
        *  
        *  Return target creature card from your graveyard to the battlefield.
        *  
        * Rulings

        *
        */
        public Resurrection() : base()
        {
            MultiverseId = 265;
            Name = "Resurrection";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            abilityCost.Add(new ManaCost(new Mana(Color.White, 1)));
            abilityCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(CardType.Sorcery);

            throw new NotImplementedException("Resurrection");
        }
        public Resurrection(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
