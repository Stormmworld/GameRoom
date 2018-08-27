using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Samite_Healer : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=268
        *  
        *  {T}: Prevent the next 1 damage that would be dealt to target creature or player this turn.
        *  
        * Rulings

        *
        */
        public Samite_Healer() : base()
        {
            MultiverseId = 268;
            Name = "Samite Healer";
            Set(1, 1);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(SubType.Human);
            Add(SubType.Cleric);
            Add(CardType.Creature);

            throw new NotImplementedException("Samite Healer");
        }
        public Samite_Healer(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
