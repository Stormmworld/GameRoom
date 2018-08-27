using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Sea_Serpent : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=124
        *  
        *  Sea Serpent can't attack unless defending player controls an Island.
When you control no Islands, sacrifice Sea Serpent.
        *  
        * Rulings

        *
        */
        public Sea_Serpent() : base()
        {
            MultiverseId = 124;
            Name = "Sea Serpent";
            Set(5, 5);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 5)));
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(SubType.Serpent);
            Add(CardType.Creature);

            throw new NotImplementedException("Sea Serpent");
        }
        public Sea_Serpent(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
