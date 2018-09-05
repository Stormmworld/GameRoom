using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;

namespace MTG.Model.Cards
{
    public class Gray_Ogre : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=204
        *  
        *  
        *  
        * Rulings
        *
        */
        public Gray_Ogre() : base()
        {
            MultiverseId = 204;
            Name = "Gray Ogre";
            Set(2, 2);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(SubType.Ogre);
            Add(CardType.Creature);
        }
        public Gray_Ogre(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
