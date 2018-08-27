using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Static;
using System.Collections.Generic;

namespace MTG.Model.Cards
{
    public class Black_Knight : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=50
        *  
        *  First strike (This creature deals combat damage before creatures without first strike.)
Protection from white (This creature can't be blocked, targeted, dealt damage, or enchanted by anything white.)
        *  
        * Rulings

        *
        */
        public Black_Knight() : base()
        {
            MultiverseId = 50;
            Name = "Black Knight";
            Set(2, 2);
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(SubType.Human);
            Add(SubType.Knight);
            Add(CardType.Creature);
            Add(new First_Strike());
            Add(Protection.From(new List<Color>() { Color.White}));
        }
        public Black_Knight(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
