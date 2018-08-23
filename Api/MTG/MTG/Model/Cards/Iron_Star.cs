using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Iron_Star : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=21
            *  
            *  Whenever a player casts a red spell, you may pay {1}. If you do, you gain 1 life.
            *  
            * Rulings

            *  
            */
        public Iron_Star() : base()
        {
            MultiverseId = 21;
            Name = "Iron Star";
	Add(Enumerations.CardType.Artifact);

            throw new NotImplementedException("Iron Star");
        }
        public Iron_Star(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
