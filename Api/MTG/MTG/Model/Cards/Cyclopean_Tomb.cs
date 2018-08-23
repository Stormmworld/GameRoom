using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Cyclopean_Tomb : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=11
            *  
            *  {2}, {T}: Put a mire counter on target non-Swamp land. That land is a Swamp for as long as it has a mire counter on it. Activate this ability only during your upkeep.
When Cyclopean Tomb is put into a graveyard from the battlefield, at the beginning of each of your upkeeps for the rest of the game, remove all mire counters from a land that a mire counter was put onto with Cyclopean Tomb but that a mire counter has not been removed from with Cyclopean Tomb.
            *  
            * Rulings
		2006-10-15: Will not add or remove Snow Supertype to or from a land.
		2008-08-01: After leaving the battlefield, the ability triggers during each of your upkeeps for the rest of the game. As it resolves, you must remove a mire counter from a land that had a mire counter put on it by that instance of Cyclopean Tomb, but it doesn't matter where the mire counter you remove came from. For instance, you could remove mire counters that were put on the land by Gilder Bairn.
		2008-08-01: The land remains a Swamp as long as it has a mire counter on it. This effect is not tied to the Tomb remaining on the battlefield.

            *  
            */
        public Cyclopean_Tomb() : base()
        {
            MultiverseId = 11;
            Name = "Cyclopean Tomb";
	Add(Enumerations.CardType.Artifact);

            throw new NotImplementedException("Cyclopean Tomb");
        }
        public Cyclopean_Tomb(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
