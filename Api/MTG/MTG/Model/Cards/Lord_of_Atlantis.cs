using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Lord_of_Atlantis : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=110
        *  
        *  Other Merfolk creatures get +1/+1 and have islandwalk. (They can't be blocked as long as defending player controls an Island.)
        *  
        * Rulings

        *
        */
        public Lord_of_Atlantis() : base()
        {
            MultiverseId = 110;
            Name = "Lord of Atlantis";
            Set(2, 2);
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(SubType.Merfolk);
            Add(CardType.Creature);

            throw new NotImplementedException("Lord of Atlantis");
        }
        public Lord_of_Atlantis(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
