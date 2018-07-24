using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Assist : IAbility
    {
            /*
             * https://mtg.gamepedia.com/Assist
                702.131a Assist is a static ability that modifies the rules of paying for the spell with assist (see rules 601.2g-h). 
                        If the total cost to cast a spell with assist includes a generic mana component, before you activate mana 
                        abilities while casting it, you may choose another player. That player has a chance to activate mana abilities. 
                        Once that player chooses not to activate any more mana abilities, you have a chance to activate mana abilities.
                        Before you begin to pay the total cost of the spell, the player you chose may pay for any amount of the 
                        generic mana in the spell’s total cost.
             */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Assist.Process");
        }
    }
}
