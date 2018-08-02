﻿using MTG.Interfaces;
using MTG.ArgumentDefintions;
using MTG.Enumerations;
using System;
using System.Collections.Generic;
using MTGModel.Objects;

namespace MTG.Model.Abilities
{
    public class Morph : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Morph
            702.36a Morph is a static ability that functions in any zone from which you could play the card 
                    it’s on, and the morph effect works any time the card is face down. “Morph [cost]” means 
                    “You may cast this card as a 2/2 face-down creature with no text, no name, no subtypes, 
                    and no mana cost by paying {3} rather than paying its mana cost.” (See rule 707, 
                    “Face-Down Spells and Permanents.”)
            702.36b Megamorph is a variant of the morph ability. “Megamorph [cost]” means “You may cast this 
                    card as a 2/2 face-down creature with no text, no name, no subtypes, and no mana cost by 
                    paying {3} rather than paying its mana cost” and “As this permanent is turned face up, 
                    put a +1/+1 counter on it if its megamorph cost was paid to turn it face up.” A megamorph 
                    cost is a morph cost.
            702.36c To cast a card using its morph ability, turn it face down. It becomes a 2/2 face-down 
                    creature card with no text, no name, no subtypes, and no mana cost. Any effects or 
                    prohibitions that would apply to casting a card with these characteristics (and not the 
                    face-up card’s characteristics) are applied to casting this card. These values are the 
                    copiable values of that object’s characteristics. (See rule 613, “Interaction of Continuous 
                    Effects,” and rule 706, “Copying Objects.”) Put it onto the stack (as a face-down spell 
                    with the same characteristics), and pay {3} rather than pay its mana cost. This follows 
                    the rules for paying alternative costs. You can use a morph ability to cast a card from 
                    any zone from which you could normally play it. When the spell resolves, it enters the 
                    battlefield with the same characteristics the spell had. The morph effect applies to 
                    the face-down object wherever it is, and it ends when the permanent is turned face up.
            702.36d You can’t normally cast a card face down. A morph ability allows you to do so.
            702.36e Any time you have priority, you may turn a face-down permanent you control with a  
                    morph ability face up. This is a special action; it doesn’t use the stack (see rule 115). 
                    To do this, show all players what the permanent’s morph cost would be if it were face up, 
                    pay that cost, then turn the permanent face up. (If the permanent wouldn’t have a morph cost 
                    if it were face up, it can’t be turned face up this way.) The morph effect on it ends, and 
                    it regains its normal characteristics. Any abilities relating to the permanent entering the 
                    battlefield don’t trigger when it’s turned face up and don’t have any effect, because the 
                    permanent has already entered the battlefield.
            702.36f If a permanent’s morph cost includes X, other abilities of that permanent may also refer 
                    to X. The value of X in those abilities is equal to the value of X chosen as the morph 
                    special action was taken.
            702.36g See rule 707, “Face-Down Spells and Permanents,” for more information about how to cast 
                    cards with a morph ability.  
        */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger;
        #endregion

        #region Properties
        public Card FaceUpCard { get; set; }
        public Card FaceDownCard
        {
            get
            {
                Card retVal = new Card()
                {
                    Power = 2,
                    Toughness = 2,
                    Name = "Morphed Card"
                };
                // need an ability to flip this card back over
                //retVal.AddAbility();
                throw new NotImplementedException("Morph.FaceDownCard");
                return retVal;
            }
        }
        public EffectTrigger Trigger { get { return EffectTrigger.Card_Cast; } }
        public AbilityType Type { get { return AbilityType.Static; } }
        #endregion

        #region Constructors
        public Morph()
        {

        }
        public Morph(Card card) : this()
        {
            FaceUpCard = card;
        }
        #endregion

        #region Methods
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Morph.Process");
        }
        #endregion
    }
}
