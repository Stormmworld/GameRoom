using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Animate_Wall : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=232
            *  
            *  Enchant Wall
                Enchanted Wall can attack as though it didn't have defender.
            *  
            * Rulings
		        2007-09-16: This is a change from the most recent wording. As was the case in the past, Animate Wall can now enchant only a Wall.

            *  
            */
        public Animate_Wall() : base()
        {
            MultiverseId = 232;
            Name = "Animate Wall";
            Add(Enumerations.Colors.White);
            Add(Enumerations.SubType.Aura);
            Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Animate Wall");
        }
        public Animate_Wall(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
