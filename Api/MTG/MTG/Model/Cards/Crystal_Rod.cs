using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Crystal_Rod : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=10
            *  
            *  Whenever a player casts a blue spell, you may pay {1}. If you do, you gain 1 life.
            *  
            * Rulings

            *  
            */
        public Crystal_Rod() : base()
        {
            MultiverseId = 10;
            Name = "Crystal Rod";
	Add(Enumerations.CardType.Artifact);

            throw new NotImplementedException("Crystal Rod");
        }
        public Crystal_Rod(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
