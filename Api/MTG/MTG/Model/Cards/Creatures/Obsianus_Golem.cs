using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;

namespace MTG.Model.Cards
{
    public class Obsianus_Golem : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=38
        *  
        *  
        *  
        * Rulings
        *
        */
        public Obsianus_Golem() : base()
        {
            MultiverseId = 38;
            Name = "Obsianus Golem";
            Set(4, 6);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 6)));
            Add(SubType.Golem);
            Add(CardType.Artifact);
            Add(CardType.Creature);
        }
        public Obsianus_Golem(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
