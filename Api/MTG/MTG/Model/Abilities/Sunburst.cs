using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Sunburst : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Sunburst
            702.43a Sunburst is a static ability that functions as an object is entering the battlefield from the stack. 
                    “Sunburst” means “If this object is entering the battlefield from the stack as a creature, it enters 
                    the battlefield with a +1/+1 counter on it for each color of mana spent to cast it. If this object 
                    is entering the battlefield from the stack and isn’t entering the battlefield as a creature, it enters 
                    the battlefield with a charge counter on it for each color of mana spent to cast it.”
            702.43b Sunburst applies only as the spell is resolving and only if one or more colored mana was spent on 
                    its costs. Mana paid for additional or alternative costs applies.
            702.43c Sunburst can also be used to set a variable number for another ability. If the keyword is used in 
                    this way, it doesn’t matter whether the ability is on a creature spell or on a noncreature spell.
                Example: The ability “Modular—Sunburst” means “This permanent enters the battlefield with a +1/+1 counter 
                        on it for each color of mana spent to cast it” and “When this permanent is put into a graveyard 
                        from the battlefield, you may put a +1/+1 counter on target artifact creature for each +1/+1 
                        counter on this permanent.”
            702.43d If an object has multiple instances of sunburst, each one works separately. 
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Sunburst.Process");
        }
    }
}
