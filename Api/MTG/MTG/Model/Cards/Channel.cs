using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Channel : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=144
        *  
        *  Until end of turn, any time you could activate a mana ability, you may pay 1 life. If you do, add {C} to your mana pool.
        *  
        * Rulings
        * 2017-11-17: Once your life total is 0, you can't pay any more life, even if you've somehow not lost the game yet.

        *
        */
        public Channel() : base()
        {
            MultiverseId = 144;
            Name = "Channel";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            abilityCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(CardType.Sorcery);

            throw new NotImplementedException("Channel");
        }
        public Channel(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
