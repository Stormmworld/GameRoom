using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Red_Elemental_Blast : Spell
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
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(CardType.Instant);

            throw new NotImplementedException("Red Elemental Blast");
        }
        public Red_Elemental_Blast(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
