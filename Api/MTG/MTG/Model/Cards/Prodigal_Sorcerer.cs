using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Prodigal_Sorcerer : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=121
        *  
        *  {T}: Prodigal Sorcerer deals 1 damage to target creature or player.
        *  
        * Rulings

        *
        */
        public Prodigal_Sorcerer() : base()
        {
            MultiverseId = 121;
            Name = "Prodigal Sorcerer";
            Set(1, 1);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(SubType.Human);
            Add(SubType.Wizard);
            Add(CardType.Creature);

            throw new NotImplementedException("Prodigal Sorcerer");
        }
        public Prodigal_Sorcerer(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
