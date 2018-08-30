using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Static;

namespace MTG.Model.Cards
{
    public class Mahamoti_Djinn : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=112
        *  
        *  Flying (This creature can't be blocked except by creatures with flying or reach.)
        *  
        * Rulings
        *
        */
        public Mahamoti_Djinn() : base()
        {
            MultiverseId = 112;
            Name = "Mahamoti Djinn";
            Set(5, 6);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 4)));
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(SubType.Djinn);
            Add(CardType.Creature);
            Add(new Flying());
        }
        public Mahamoti_Djinn(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
