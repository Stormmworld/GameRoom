using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Partner : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Partner
            702.123a Partner is an ability that modifies the rules for deck construction in the Commander variant 
                    (see rule 903), and it functions before the game begins. Rather than a single legendary 
                    creature card, you may designate two legendary creature cards as your commander if each has 
                    partner.
            702.123b Your deck must contain exactly 100 cards, including its two commanders. Both commanders begin 
                    the game in the command zone.
            702.123c A rule or effect that refers to your commander’s color identity refers to the combined color 
                    identities of your two commanders. See rule 903.4.
            702.123d Except for determining the color identity of your commander, the two commanders function 
                    independently. When casting a commander with partner, ignore how many times your other 
                    commander has been cast. When determining whether a player has been dealt 21 or more combat 
                    damage by the same  commander, consider damage from each of your two commanders separately. 
                    See rule 903.11a.
            702.123e If an effect refers to your commander while you have two commanders, it refers to either 
                    one. If an 
                    effect causes you to perform an action on your commander and it could affect both, you choose
                    which it refers to at the time the effect is applied.
            702.123f “Partner with [name]” is a variant of the partner ability. “Partner with [name]” represents two 
                    abilities. One is a static ability that modifies the rules for deck construction. Rather than a 
                    single legendary creature card, you may designate two legendary creature cards as your commander 
                    if each has a “partner with [name]” ability with the other’s name. You can’t designate two 
                    legendary cards as your commander if one has a “partner with [name]” ability and the other 
                    isn’t the named card. The other ability represented by “partner with [name]” is a triggered 
                    ability that means “When this permanent enters the battlefield, target player may search their 
                    library for a card named [name], reveal it, put it into their hand, then shuffle their library.”
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Partner.Process");
        }
    }
}
