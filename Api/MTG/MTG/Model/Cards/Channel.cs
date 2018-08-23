using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Channel : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=144
            *  
            *  Until end of turn, any time you could activate a mana ability, you may pay 1 life. If you do, add {C} to your mana pool.
            *  
            * Rulings
		2017-11-17: Once your life total is 0, you can't pay any more life, even if you've somehow not lost the game yet.

            *  
            */
        public Channel() : base()
        {
            MultiverseId = 144;
            Name = "Channel";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.CardType.Sorcery);

            throw new NotImplementedException("Channel");
        }
        public Channel(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
