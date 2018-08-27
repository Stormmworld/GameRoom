using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Time_Walk : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=131
        *  
        *  Take an extra turn after this one.
        *  
        * Rulings
        * 2004-10-04: If multiple "extra turn" effects resolve in the same turn, take them in the reverse of the order that the effects resolved.

        *
        */
        public Time_Walk() : base()
        {
            MultiverseId = 131;
            Name = "Time Walk";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            abilityCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(CardType.Sorcery);

            throw new NotImplementedException("Time Walk");
        }
        public Time_Walk(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
