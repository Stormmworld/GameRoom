using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;

namespace MTG.Model.Cards
{
    public class Fire_Elemental : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=196
        *  
        *  
        *  
        * Rulings
        *
        */
        public Fire_Elemental() : base()
        {
            MultiverseId = 196;
            Name = "Fire Elemental";
            Set(5, 4);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(SubType.Elemental);
            Add(CardType.Creature);
        }
        public Fire_Elemental(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
