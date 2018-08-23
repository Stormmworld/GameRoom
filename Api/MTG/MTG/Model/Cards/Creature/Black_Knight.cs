using MTG.Enumerations;
using MTG.Model.Abilities.Static;
using MTG.Model.Objects;
using System.Collections.Generic;

namespace MTG.Model.Cards
{
    public class Black_Knight : Card
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
            _Power = 2;
            _Toughness = 2;
            CastingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Black, Count = 2 } });
            Add(Enumerations.Colors.Black);
            Add(SubType.Human);
            Add(SubType.Knight);
            Add(CardType.Creature);
            Add(new First_Strike());
            Add(Protection.From(new List<Colors>() { Enumerations.Colors.White }));
        }
        public Black_Knight(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
