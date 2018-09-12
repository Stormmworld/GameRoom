using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;

namespace MTG.Model.Cards
{
    public class Merfolk_of_the_Pearl_Trident : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=114
        *  
        *  
        *  
        * Rulings
        *
        */
        public Merfolk_of_the_Pearl_Trident() : base()
        {
            MultiverseId = 114;
            Name = "Merfolk of the Pearl Trident";
            Set(1, 1);
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(SubType.Merfolk);
            Add(CardType.Creature);
        }
        public Merfolk_of_the_Pearl_Trident(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
