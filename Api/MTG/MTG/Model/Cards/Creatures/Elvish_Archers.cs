using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Static;

namespace MTG.Model.Cards
{
    public class Elvish_Archers : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=147
        *  
        *  First strike
        *  
        * Rulings

        *
        */
        public Elvish_Archers() : base()
        {
            MultiverseId = 147;
            Name = "Elvish Archers";
            Set(2, 1);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(SubType.Elf);
            Add(SubType.Archer);
            Add(CardType.Creature);
            Add(new First_Strike());
        }
        public Elvish_Archers(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
