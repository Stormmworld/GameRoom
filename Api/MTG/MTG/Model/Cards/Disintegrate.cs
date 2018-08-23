using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Disintegrate : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=188
            *  
            *  Disintegrate deals X damage to target creature or player. That creature can't be regenerated this turn. If the creature would die this turn, exile it instead.
            *  
            * Rulings
		2004-10-04: The "can't regenerate" is an effect of Disintegrate and not an effect of the damage. It works even if the damage is prevented or redirected. If redirected, the damage does not take this effect with it.
		2004-10-04: Disintegrated creatures do not go to the graveyard at all before being exiled. They do not trigger abilities which trigger due to a creature going to the graveyard.

            *  
            */
        public Disintegrate() : base()
        {
            MultiverseId = 188;
            Name = "Disintegrate";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.CardType.Sorcery);

            throw new NotImplementedException("Disintegrate");
        }
        public Disintegrate(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}