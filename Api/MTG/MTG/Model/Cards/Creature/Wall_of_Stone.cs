using MTG.Model.Abilities.Static;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Wall_of_Stone : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=230
            *  
            *  Defender (This creature can't attack.)
            *  
            * Rulings

            *  
            */
        public Wall_of_Stone() : base()
        {
            MultiverseId = 230;
            Name = "Wall of Stone";
            _Power = 0;
            _Toughness = 8;
            Add(Enumerations.Colors.Red);
            Add(Enumerations.SubType.Wall);
            Add(Enumerations.CardType.Creature);
            Add(new Defender());

            throw new NotImplementedException("Wall of Stone");
        }
        public Wall_of_Stone(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
