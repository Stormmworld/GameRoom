using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Warp_Artifact : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=89
            *  
            *  Enchant artifact
At the beginning of the upkeep of enchanted artifact's controller, Warp Artifact deals 1 damage to that player.
            *  
            * Rulings

            *  
            */
        public Warp_Artifact() : base()
        {
            MultiverseId = 89;
            Name = "Warp Artifact";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Warp Artifact");
        }
        public Warp_Artifact(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
