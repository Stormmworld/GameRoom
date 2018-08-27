using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Grizzly_Bears : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=155
        *  
        *  
        *  
        * Rulings

        *
        */
        public Grizzly_Bears() : base()
        {
            MultiverseId = 155;
            Name = "Grizzly Bears";
            Set(2, 2);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(SubType.Bear);
            Add(CardType.Creature);

            throw new NotImplementedException("Grizzly Bears");
        }
        public Grizzly_Bears(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
