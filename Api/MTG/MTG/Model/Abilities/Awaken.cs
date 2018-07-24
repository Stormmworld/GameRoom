using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Awaken : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Awaken
            702.112a Awaken appears on some instants and sorceries. It represents two abilities: a static ability that 
                    functions while the spell with awaken is on the stack and a spell ability. “Awaken N—[cost]” means 
                    “You may pay [cost] rather than pay this spell’s mana cost as you cast this spell” and “If this spell’s 
                    awaken cost was paid, put N +1/+1 counters on target land you control. That land becomes a 0/0 Elemental 
                    creature with haste. It’s still a land.” Paying a spell’s awaken cost follows the rules for paying alternative 
                    costs in rules 601.2b and 601.2f–h.
            702.112b The controller of a spell with awaken chooses the target of the awaken spell ability only if that player
                    chose to pay the spell’s awaken cost. Otherwise the spell is cast as if it didn’t have that target.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Awaken.Process");
        }
    }
}
