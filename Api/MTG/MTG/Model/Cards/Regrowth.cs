using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Regrowth : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=170
        *  
        *  Return target card from your graveyard to your hand.
        *  
        * Rulings

        *
        */
        public Regrowth() : base()
        {
            MultiverseId = 170;
            Name = "Regrowth";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            abilityCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(CardType.Sorcery);

            throw new NotImplementedException("Regrowth");
        }
        public Regrowth(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
