using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Suspend : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Suspend
            702.61a Suspend is a keyword that represents three abilities. The first is a static 
                    ability that functions while the card with suspend is in a player’s hand. 
                    The second and third are triggered abilities that function in the exile 
                    zone. “Suspend N—[cost]” means “If you could begin to cast this card by 
                    putting it onto the stack from your hand, you may pay [cost] and exile it 
                    with N time counters on it. This action doesn’t use the stack,” and “At the 
                    beginning of your upkeep, if this card is suspended, remove a time counter from 
                    it,” and “When the last time counter is removed from this card, if it’s exiled, 
                    play it without paying its mana cost if able. If you can’t, it remains exiled. 
                    If you cast a creature spell this way, it gains haste until you lose control 
                    of the spell or the permanent it becomes.”
            702.61b A card is “suspended” if it’s in the exile zone, has suspend, and has a 
                    time counter on it.
            702.61c While determining if you could begin to cast a card with suspend, take into 
                    consideration any effects that would prohibit that card from being cast.
            702.61d Casting a spell as an effect of its suspend ability follows the rules for 
                    paying alternative costs in rules 601.2b and 601.2f–h.   
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
