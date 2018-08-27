using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Lifeforce : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=162
        *  
        *  {G}{G}: Counter target black spell.
        *  
        * Rulings

        *
        */
        public Lifeforce() : base()
        {
            MultiverseId = 162;
            Name = "Lifeforce";
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Lifeforce");
        }
        public Lifeforce(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
