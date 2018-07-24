using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Crew : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Crew
            702.121a Crew is an activated ability of Vehicle cards. “Crew N” means “Tap any number 
                    of untapped creatures you control with total power N or greater: This permanent 
                    becomes an artifact creature until end of turn.”
            702.121b A creature “crews a Vehicle” when it’s tapped to pay the cost to activate a 
                    Vehicle’s crew ability.
            702.121c If an effect states that a creature “can’t crew Vehicles,” that creature 
                    can’t be tapped to pay the crew cost of a Vehicle.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Crew.Process");
        }
    }
}
