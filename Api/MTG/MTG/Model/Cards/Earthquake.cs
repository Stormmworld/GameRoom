using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Earthquake : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=194
            *  
            *  Earthquake deals X damage to each creature without flying and each player.
            *  
            * Rulings
		2004-10-04: Whether or not a creature is without flying is only checked on resolution.

            *  
            */
        public Earthquake() : base()
        {
            MultiverseId = 194;
            Name = "Earthquake";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.CardType.Sorcery);

            throw new NotImplementedException("Earthquake");
        }
        public Earthquake(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
