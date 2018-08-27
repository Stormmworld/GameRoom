using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Mind_Twist : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=71
        *  
        *  Target player discards X cards at random.
        *  
        * Rulings

        *
        */
        public Mind_Twist() : base()
        {
            MultiverseId = 71;
            Name = "Mind Twist";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, true)));
            abilityCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(CardType.Sorcery);

            throw new NotImplementedException("Mind Twist");
        }
        public Mind_Twist(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
