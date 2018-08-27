using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Righteousness : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=267
        *  
        *  Target blocking creature gets +7/+7 until end of turn.
        *  
        * Rulings
        * 2009-10-01: A "blocking creature" is one that has been declared as a blocker this combat, or one that was put onto the battlefield blocking this combat. Unless that creature leaves combat, it continues to be a blocking creature through the end of combat step, even if the creature or creatures it was blocking are no longer on the battlefield or have otherwise left combat.

        *
        */
        public Righteousness() : base()
        {
            MultiverseId = 267;
            Name = "Righteousness";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(CardType.Instant);

            throw new NotImplementedException("Righteousness");
        }
        public Righteousness(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
