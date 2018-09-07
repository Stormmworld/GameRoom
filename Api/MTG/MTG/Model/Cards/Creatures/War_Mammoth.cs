using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Static;

namespace MTG.Model.Cards
{
    public class War_Mammoth : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=183
        *  
        *  Trample
        *  
        * Rulings
        *
        */
        public War_Mammoth() : base()
        {
            MultiverseId = 183;
            Name = "War Mammoth";
            Set(3, 3);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(SubType.Elephant);
            Add(CardType.Creature);
            Add(new Trample());
        }
        public War_Mammoth(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
