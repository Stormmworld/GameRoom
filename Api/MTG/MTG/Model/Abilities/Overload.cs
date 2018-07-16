using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Overload : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Overload
            702.95a Overload is a keyword that represents two static abilities that function while the spell with 
                    overload is on the stack. Overload [cost] means “You may choose to pay [cost] rather than pay 
                    this spell’s mana cost” and “If you chose to pay this spell’s overload cost, change its text 
                    by replacing all instances of the word ‘target’ with the word ‘each.’” Using the overload 
                    ability follows the rules for paying alternative costs in rules 601.2b and 601.2f–h.
            702.95b If a player chooses to pay the overload cost of a spell, that spell won’t require any targets. 
                    It may affect objects that couldn’t be chosen as legal targets if the spell were cast without 
                    its overload cost being paid.
            702.95c Overload’s second ability creates a text-changing effect. See rule 612, “Text-Changing Effects.”    
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
