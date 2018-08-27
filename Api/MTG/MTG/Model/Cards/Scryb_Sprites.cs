using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Scryb_Sprites : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=171
        *  
        *  Flying
        *  
        * Rulings

        *
        */
        public Scryb_Sprites() : base()
        {
            MultiverseId = 171;
            Name = "Scryb Sprites";
            Set(1, 1);
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(SubType.Faerie);
            Add(CardType.Creature);

            throw new NotImplementedException("Scryb Sprites");
        }
        public Scryb_Sprites(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
