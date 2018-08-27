using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Dwarven_Demolition_Team : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=190
        *  
        *  {T}: Destroy target Wall.
        *  
        * Rulings

        *
        */
        public Dwarven_Demolition_Team() : base()
        {
            MultiverseId = 190;
            Name = "Dwarven Demolition Team";
            Set(1, 1);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(SubType.Dwarf);
            Add(CardType.Creature);

            throw new NotImplementedException("Dwarven Demolition Team");
        }
        public Dwarven_Demolition_Team(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
