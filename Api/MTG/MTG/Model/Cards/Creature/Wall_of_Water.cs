using MTG.Model.Abilities.Static;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Wall_of_Water : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=138
            *  
            *  Defender (This creature can't attack.)
                {U}: Wall of Water gets +1/+0 until end of turn.
            *  
            * Rulings

            *  
            */
        public Wall_of_Water() : base()
        {
            MultiverseId = 138;
            Name = "Wall of Water";
            _Power = 0;
            _Toughness = 5;
            Add(Enumerations.Colors.Blue);
            Add(Enumerations.SubType.Wall);
            Add(Enumerations.CardType.Creature);
            Add(new Defender());

            throw new NotImplementedException("Wall of Water");
        }
        public Wall_of_Water(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
