using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Blue_Elemental_Blast : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=97
            *  
            *  Choose one —
• Counter target red spell.
• Destroy target red permanent.
            *  
            * Rulings
		2004-10-04: The decision to counter a spell or destroy a permanent is a decision made on announcement before the target is selected. If the spell is redirected, this mode can't be changed, so only targets of the selected type are valid.

            *  
            */
        public Blue_Elemental_Blast() : base()
        {
            MultiverseId = 97;
            Name = "Blue Elemental Blast";
	Add(Enumerations.Colors.Blue);
	Add(Enumerations.CardType.Instant);

            throw new NotImplementedException("Blue Elemental Blast");
        }
        public Blue_Elemental_Blast(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
