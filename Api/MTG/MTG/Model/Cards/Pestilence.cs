using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Pestilence : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=76
            *  
            *  At the beginning of the end step, if no creatures are on the battlefield, sacrifice Pestilence.
{B}: Pestilence deals 1 damage to each creature and each player.
            *  
            * Rulings
		2004-10-04: Each activation is considered a new damage effect. An activation can only be 1 point of damage.
		2011-06-01: Note that "until end of turn" effects wear off after "at the beginning of the end step" triggered abilities, so an artifact that animates until end of turn can keep this on the battlefield.
		2011-06-01: It will stay on the battlefield if there is a creature that is put into the graveyard during the end step. This is because this ability will not trigger at all if there is at least one creature on the battlefield as the end step begins.

            *  
            */
        public Pestilence() : base()
        {
            MultiverseId = 76;
            Name = "Pestilence";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Pestilence");
        }
        public Pestilence(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
