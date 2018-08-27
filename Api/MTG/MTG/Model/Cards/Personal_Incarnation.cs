using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Personal_Incarnation : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=262
        *  
        *  {0}: The next 1 damage that would be dealt to Personal Incarnation this turn is dealt to its owner instead. Only Personal Incarnation's owner may activate this ability.
When Personal Incarnation dies, its owner loses half his or her life, rounded up.
        *  
        * Rulings
        * 2004-10-04: You do not lose life if this card is exiled or sent someplace without going to the graveyard first.
        * 2004-10-04: The owner of the Incarnation loses life when it is destroyed, not the controller. So if you control your opponent's Incarnation you can let it die to make them lose life.
        * 2007-02-01: If you attempt to halve a negative life total, you halve 0. This means that the life total stays the same. A life total of -10 would remain -10.

        *
        */
        public Personal_Incarnation() : base()
        {
            MultiverseId = 262;
            Name = "Personal Incarnation";
            Set(6, 6);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(SubType.Avatar);
            Add(SubType.Incarnation);
            Add(CardType.Creature);

            throw new NotImplementedException("Personal Incarnation");
        }
        public Personal_Incarnation(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
