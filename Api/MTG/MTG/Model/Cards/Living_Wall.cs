using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Living_Wall : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=29
        *  
        *  Defender (This creature can't attack.)
{1}: Regenerate Living Wall.
        *  
        * Rulings

        *
        */
        public Living_Wall() : base()
        {
            MultiverseId = 29;
            Name = "Living Wall";
            Set(0, 6);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 4)));
            Add(SubType.Wall);
            Add(CardType.Artifact);
            Add(CardType.Creature);

            throw new NotImplementedException("Living Wall");
        }
        public Living_Wall(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
