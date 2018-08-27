using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Pirate_Ship : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=118
        *  
        *  Pirate Ship can't attack unless defending player controls an Island.
{T}: Pirate Ship deals 1 damage to target creature or player.
When you control no Islands, sacrifice Pirate Ship.
        *  
        * Rulings

        *
        */
        public Pirate_Ship() : base()
        {
            MultiverseId = 118;
            Name = "Pirate Ship";
            Set(4, 3);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 4)));
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(SubType.Human);
            Add(SubType.Pirate);
            Add(CardType.Creature);

            throw new NotImplementedException("Pirate Ship");
        }
        public Pirate_Ship(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
