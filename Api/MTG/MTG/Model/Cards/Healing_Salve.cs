using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Healing_Salve : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=253
            *  
            *  Choose one —
• Target player gains 3 life.
• Prevent the next 3 damage that would be dealt to target creature or player this turn.
            *  
            * Rulings

            *  
            */
        public Healing_Salve() : base()
        {
            MultiverseId = 253;
            Name = "Healing Salve";
	Add(Enumerations.Colors.White);
	Add(Enumerations.CardType.Instant);

            throw new NotImplementedException("Healing Salve");
        }
        public Healing_Salve(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
