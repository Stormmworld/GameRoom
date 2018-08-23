using MTG.Model.Abilities.Static;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Wall_of_Fire : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=229
            *  
            *  Defender (This creature can't attack.)
                {R}: Wall of Fire gets +1/+0 until end of turn.
            *  
            * Rulings

            *  
            */
        public Wall_of_Fire() : base()
        {
            MultiverseId = 229;
            Name = "Wall of Fire";
            _Power = 0;
            _Toughness = 5;
            Add(Enumerations.Colors.Red);
            Add(Enumerations.SubType.Wall);
            Add(Enumerations.CardType.Creature);
            Add(new Defender());

            throw new NotImplementedException("Wall of Fire");
        }
        public Wall_of_Fire(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
