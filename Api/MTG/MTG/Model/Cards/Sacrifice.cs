using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Sacrifice : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=80
            *  
            *  As an additional cost to cast Sacrifice, sacrifice a creature.
Add an amount of {B} to your mana pool equal to the sacrificed creature's converted mana cost.
            *  
            * Rulings
		2004-10-04: Sacrificing an animated land gives no mana since the converted mana cost was zero.
		2013-04-15: You must sacrifice exactly one creature to cast this spell; you cannot cast it without sacrificing a creature, and you cannot sacrifice additional creatures.
		2013-04-15: Players can only respond once this spell has been cast and all its costs have been paid. No one can try to destroy the creature you sacrificed to prevent you from casting this spell.

            *  
            */
        public Sacrifice() : base()
        {
            MultiverseId = 80;
            Name = "Sacrifice";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.CardType.Instant);

            throw new NotImplementedException("Sacrifice");
        }
        public Sacrifice(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}