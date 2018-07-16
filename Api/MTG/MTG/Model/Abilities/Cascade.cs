using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Cascade : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Cascade
            702.84a Cascade is a triggered ability that functions only while the spell with cascade 
                    is on the stack. “Cascade” means “When you cast this spell, exile cards from 
                    the top of your library until you exile a nonland card whose converted mana cost 
                    is less than this spell’s converted mana cost. You may cast that card without 
                    paying its mana cost. Then put all cards exiled this way that weren’t cast on 
                    the bottom of your library in a random order.”
            702.84b If a spell has multiple instances of cascade, each triggers separately.
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
