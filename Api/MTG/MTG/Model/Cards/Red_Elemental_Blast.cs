using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Red_Elemental_Blast : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=217
            *  
            *  Choose one —
• Counter target blue spell.
• Destroy target blue permanent.
            *  
            * Rulings

            *  
            */
        public Red_Elemental_Blast() : base()
        {
            MultiverseId = 217;
            Name = "Red Elemental Blast";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.CardType.Instant);

            throw new NotImplementedException("Red Elemental Blast");
        }
        public Red_Elemental_Blast(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
