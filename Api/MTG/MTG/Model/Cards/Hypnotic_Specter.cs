using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Hypnotic_Specter : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=68
            *  
            *  Flying
Whenever Hypnotic Specter deals damage to an opponent, that player discards a card at random.
            *  
            * Rulings
		2008-08-01: The ability triggers even if the Specter's damage is being redirected to an opponent. It does not trigger if damage that would have been dealt to the opponent is redirected to a nonopponent player or a creature, or if the damage is prevented.

            *  
            */
        public Hypnotic_Specter() : base()
        {
            MultiverseId = 68;
            Name = "Hypnotic Specter";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.SubType.Specter);
	Add(Enumerations.CardType.Creature);
	_Power = 2;
		_Toughness = 2;

            throw new NotImplementedException("Hypnotic Specter");
        }
        public Hypnotic_Specter(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
