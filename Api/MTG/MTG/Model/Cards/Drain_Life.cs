using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Drain_Life : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=61
            *  
            *  Spend only black mana on X.
Drain Life deals X damage to target creature or player. You gain life equal to the damage dealt, but not more life than the player's life total before Drain Life dealt damage or the creature's toughness.
            *  
            * Rulings
		2004-10-04: Cost reducers can be used to reduce the X part of the mana cost.
		2004-10-04: You may gain up to the total toughness of the creature even if it was already damaged.

            *  
            */
        public Drain_Life() : base()
        {
            MultiverseId = 61;
            Name = "Drain Life";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.CardType.Sorcery);

            throw new NotImplementedException("Drain Life");
        }
        public Drain_Life(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
