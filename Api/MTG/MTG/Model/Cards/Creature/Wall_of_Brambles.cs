using MTG.Model.Abilities.Static;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Wall_of_Brambles : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=179
            *  
            *  Defender (This creature can't attack.)
                {G}: Regenerate Wall of Brambles.
            *  
            * Rulings

            *  
            */
        public Wall_of_Brambles() : base()
        {
            MultiverseId = 179;
            Name = "Wall of Brambles";
            Add(Enumerations.Colors.Green);
            Add(Enumerations.SubType.Plant);
            Add(Enumerations.SubType.Wall);
            Add(Enumerations.CardType.Creature);
            Add(new Defender());
            _Power = 2;
            _Toughness = 3;

            throw new NotImplementedException("Wall of Brambles");
        }
        public Wall_of_Brambles(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
