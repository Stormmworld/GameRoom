using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Ice_Storm : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=157
        *  
        *  Destroy target land.
        *  
        * Rulings

        *
        */
        public Ice_Storm() : base()
        {
            MultiverseId = 157;
            Name = "Ice Storm";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            abilityCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(CardType.Sorcery);

            throw new NotImplementedException("Ice Storm");
        }
        public Ice_Storm(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
