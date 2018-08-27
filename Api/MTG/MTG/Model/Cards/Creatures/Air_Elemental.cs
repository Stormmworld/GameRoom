using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Abilities.Static;

namespace MTG.Model.Cards
{
    public class Air_Elemental : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=94
        *  
        *  Flying
        *  
        * Rulings

        *
        */
        public Air_Elemental() : base()
        {
            MultiverseId = 94;
            Name = "Air Elemental";
            Set(4, 4);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(SubType.Elemental);
            Add(CardType.Creature);
            Add(new Flying());
        }
        public Air_Elemental(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
