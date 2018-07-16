﻿using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Cycling : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Cycling
            702.28a Cycling is an activated ability that functions only while the card with cycling is in 
                    a player’s hand. “Cycling [cost]” means “[Cost], Discard this card: Draw a card.”
            702.28b Although the cycling ability can be activated only if the card is in a player’s hand, 
                    it continues to exist while the object is on the battlefield and in all other zones. 
                    Therefore objects with cycling will be affected by effects that depend on objects 
                    having one or more activated abilities.
            702.28c Some cards with cycling have abilities that trigger when they’re cycled. “When you 
                    cycle [this card]” means “When you discard [this card] to pay an activation cost of 
                    a cycling ability.” These abilities trigger from whatever zone the card winds up 
                    in after it’s cycled.
            702.28d Some cards have abilities that trigger whenever a player “cycles or discards” a card. 
                    These abilities trigger only once when a card is cycled.
            702.28e Typecycling is a variant of the cycling ability. “[Type]cycling [cost]” means “[Cost], 
                    Discard this card: Search your library for a [type] card, reveal it, and put it into 
                    your hand. Then shuffle your library.” This type is usually a subtype (as in 
                    “mountaincycling”) but can be any card type, subtype, supertype, or combination 
                    thereof (as in “basic landcycling”).
            702.28f Typecycling abilities are cycling abilities, and typecycling costs are cycling costs. 
                    Any cards that trigger when a player cycles a card will trigger when a card is discarded to 
                    pay an activation cost of a typecycling ability. Any effect that stops players from cycling 
                    cards will stop players from activating cards’ typecycling abilities. Any effect that 
                    increases or reduces a cycling cost will increase or reduce a typecycling cost. Any effect 
                    that looks for a card with cycling will find a card with typecycling.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
