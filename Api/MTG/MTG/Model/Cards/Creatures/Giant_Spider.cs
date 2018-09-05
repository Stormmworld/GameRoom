using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Static;

namespace MTG.Model.Cards
{
    public class Giant_Spider : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=154
        *  
        *  Reach (This creature can block creatures with flying.)
        *  
        * Rulings
        * 2008-04-01: This card now uses the Reach keyword ability to enable the blocking of flying creatures. This works because a creature with flying can only be blocked by creatures with flying or reach.

        *
        */
        public Giant_Spider() : base()
        {
            MultiverseId = 154;
            Name = "Giant Spider";
            Set(2, 4);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(SubType.Spider);
            Add(CardType.Creature);
            Add(new Reach());
        }
        public Giant_Spider(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
