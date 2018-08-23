using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Jade_Monolith : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=23
            *  
            *  {1}: The next time a source of your choice would deal damage to target creature this turn, that source deals that damage to you instead.
            *  
            * Rulings

            *  
            */
        public Jade_Monolith() : base()
        {
            MultiverseId = 23;
            Name = "Jade Monolith";
	Add(Enumerations.CardType.Artifact);

            throw new NotImplementedException("Jade Monolith");
        }
        public Jade_Monolith(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
