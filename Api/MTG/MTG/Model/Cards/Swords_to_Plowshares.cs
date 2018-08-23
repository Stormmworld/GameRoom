using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Swords_to_Plowshares : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=271
            *  
            *  Exile target creature. Its controller gains life equal to its power.
            *  
            * Rulings
		2017-11-17: The amount of life gained is equal to the power of the target creature as it last existed on the battlefield.
		2017-11-17: If the creature's power is negative, its controller doesn't lose or gain life.

            *  
            */
        public Swords_to_Plowshares() : base()
        {
            MultiverseId = 271;
            Name = "Swords to Plowshares";
	Add(Enumerations.Colors.White);
	Add(Enumerations.CardType.Instant);

            throw new NotImplementedException("Swords to Plowshares");
        }
        public Swords_to_Plowshares(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
