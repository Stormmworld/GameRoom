using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Soulshift : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Soulshift
            702.45a Soulshift is a triggered ability. “Soulshift N” means “When this permanent is put into a graveyard 
                    from the battlefield, you may return target Spirit card with converted mana cost N or less from 
                    your graveyard to your hand.”
            702.45b If a permanent has multiple instances of soulshift, each triggers separately.
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
