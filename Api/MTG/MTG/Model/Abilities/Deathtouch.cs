using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Deathtouch : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Deathtouch
            702.2a Deathtouch is a static ability.
            702.2b A creature with toughness greater than 0 that’s been dealt damage by a source with deathtouch 
                    since the last time state-based actions were checked is destroyed as a state-based action. 
                    See rule 704.
            702.2c Any nonzero amount of combat damage assigned to a creature by a source with deathtouch is 
                    considered to be lethal damage for the purposes of determining if a proposed combat damage 
                    assignment is valid, regardless of that creature’s toughness. See rules 510.1c–d.
            702.2d The deathtouch rules function no matter what zone an object with deathtouch deals damage from.
            702.2e If an object changes zones before an effect causes it to deal damage, its last known 
                    information is used to determine whether it had deathtouch.
            702.2f Multiple instances of deathtouch on the same object are redundant.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Deathtouch.Process");
        }
    }
}
