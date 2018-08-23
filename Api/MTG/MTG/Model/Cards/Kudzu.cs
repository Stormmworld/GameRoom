using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Kudzu : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=160
            *  
            *  Enchant land
When enchanted land becomes tapped, destroy it. That land's controller attaches Kudzu to a land of his or her choice.
            *  
            * Rulings
		2004-10-04: You can move it to any other player's land whenever you get to move it.
		2005-08-01: If Kudzu is destroyed directly, or the land is destroyed by a spell or ability, then Kudzu goes to the graveyard like any Aura would.
		2008-04-01: The controller of the destroyed land must attach it to another land if possible. If there are no valid choices, Kudzu is simply put into the graveyard.
		2008-04-01: Because the ability isn't targeted, the controller of the destroyed land may attach it to a land that can't be the target of abilities.

            *  
            */
        public Kudzu() : base()
        {
            MultiverseId = 160;
            Name = "Kudzu";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Kudzu");
        }
        public Kudzu(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
