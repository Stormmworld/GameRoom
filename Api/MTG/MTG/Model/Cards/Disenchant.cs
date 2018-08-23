using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Disenchant : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=249
            *  
            *  Destroy target artifact or enchantment.
            *  
            * Rulings
		2004-10-04: This is not modal. If the target changes from an artifact to an enchantment or vice versa, this still destroys it.

            *  
            */
        public Disenchant() : base()
        {
            MultiverseId = 249;
            Name = "Disenchant";
	Add(Enumerations.Colors.White);
	Add(Enumerations.CardType.Instant);

            throw new NotImplementedException("Disenchant");
        }
        public Disenchant(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
