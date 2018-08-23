using MTG.Model.Abilities.Static;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Wall_of_Air : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=137
            *  
            *  Defender, flying (This creature can't attack, and it can block creatures with flying.)
            *  
            * Rulings

            *  
            */
        public Wall_of_Air() : base()
        {
            MultiverseId = 137;
            Name = "Wall of Air";
            _Power = 1;
            _Toughness = 5;
            CastingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Blue, Count = 2 } });
            CastingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Colorless, Count = 1 } });
            Add(Enumerations.Colors.Blue);
            Add(Enumerations.SubType.Wall);
            Add(Enumerations.CardType.Creature);
            Add(new Defender());
            Add(new Flying());
        }
        public Wall_of_Air(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
