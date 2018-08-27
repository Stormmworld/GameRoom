using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Healing_Salve : Spell
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
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(CardType.Instant);

            throw new NotImplementedException("Healing Salve");
        }
        public Healing_Salve(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
