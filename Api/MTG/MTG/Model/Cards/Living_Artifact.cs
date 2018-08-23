using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Living_Artifact : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=164
            *  
            *  Enchant artifact
Whenever you're dealt damage, put that many vitality counters on Living Artifact.
At the beginning of your upkeep, you may remove a vitality counter from Living Artifact. If you do, you gain 1 life.
            *  
            * Rulings
		2004-10-04: You can cast it targeting your opponent's artifacts. The controller of the Aura (not the controller of the artifact) controls the Living Artifact ability.
		2004-10-04: Does not trigger on loss of life, just on damage.

            *  
            */
        public Living_Artifact() : base()
        {
            MultiverseId = 164;
            Name = "Living Artifact";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Living Artifact");
        }
        public Living_Artifact(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
