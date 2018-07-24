using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Split_Second : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Split_second
            702.60a Split second is a static ability that functions only while the spell with split second is on the stack. 
                    “Split second” means “As long as this spell is on the stack, players can’t cast other spells or activate 
                    abilities that aren’t mana abilities.”
            702.60b Players may activate mana abilities and take special actions while a spell with split second is on the 
                    stack. Triggered abilities trigger and are put on the stack as normal while a spell with split second is 
                    on the stack.
            702.60c Multiple instances of split second on the same spell are redundant.
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Split_Second.Process");
        }
    }
}
