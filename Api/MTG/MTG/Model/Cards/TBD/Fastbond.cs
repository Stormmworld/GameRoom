using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Fastbond : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=148
        *  
        *  You may play any number of lands on each of your turns.
Whenever you play a land, if it wasn't the first land you played this turn, Fastbond deals 1 damage to you.
        *  
        * Rulings
        * 2004-10-04: You take damage when you play a land using the "play a land" action. Such an action can be your regular "play a land", one enabled by Fastbond, or ones enabled through other effects.
        * 2004-10-04: You do not take damage when you "put a land onto the battlefield" through the effect of a spell or ability.

        *
        */
        public Fastbond() : base()
        {
            MultiverseId = 148;
            Name = "Fastbond";
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Fastbond");
        }
        public Fastbond(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
