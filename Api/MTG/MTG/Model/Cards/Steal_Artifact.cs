using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Steal_Artifact : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=129
            *  
            *  Enchant artifact
You control enchanted artifact.
            *  
            * Rulings
		2004-10-04: Can be used on artifact creatures.

            *  
            */
        public Steal_Artifact() : base()
        {
            MultiverseId = 129;
            Name = "Steal Artifact";
	Add(Enumerations.Colors.Blue);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Steal Artifact");
        }
        public Steal_Artifact(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
