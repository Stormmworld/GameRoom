using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Copper_Tablet : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=9
            *  
            *  At the beginning of each player's upkeep, Copper Tablet deals 1 damage to that player.
            *  
            * Rulings

            *  
            */
        public Copper_Tablet() : base()
        {
            MultiverseId = 9;
            Name = "Copper Tablet";
	Add(Enumerations.CardType.Artifact);

            throw new NotImplementedException("Copper Tablet");
        }
        public Copper_Tablet(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
