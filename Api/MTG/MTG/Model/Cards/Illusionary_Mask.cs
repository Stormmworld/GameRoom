using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Illusionary_Mask : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=20
        *  
        *  {X}: You may choose a creature card in your hand whose mana cost could be paid by some amount of, or all of, the mana you spent on {X}. If you do, you may cast that card face down as a 2/2 creature spell without paying its mana cost. If the creature that spell becomes as it resolves has not been turned face up and would assign or deal damage, be dealt damage, or become tapped, instead it's turned face up and assigns or deals damage, is dealt damage, or becomes tapped. Activate this ability only any time you could cast a sorcery.
        *  
        * Rulings
        * 2004-10-04: The creature enters the battlefield face down, so none of its "enters the battlefield" abilities will trigger or have any effect. Also none of its "As this enters the battlefield" abilities apply.
        * 2004-10-04: The creature's "enters the battlefield" abilities (and any other abilities relating to the creature entering the battlefield) do not trigger when it turns face up.
        * 2004-10-04: Only the controller of the face down creature can look at it.
        * 2008-04-01: A "creature card" is any card with the type creature, even if it has other types such as artifact, enchantment, or land. Older cards of type summon are also creature cards.
        * 2009-10-01: If you use the ability to cast a creature card face down, you must keep track of the amount and types of mana you spent on {X}. If that creature spell is moved from the stack to anywhere other than the battlefield, the resulting creature leaves the battlefield, or the game ends, the face-down card is revealed. If its mana cost couldn't be paid by some amount of, or all of, the mana you spent on {X}, all applicable penalties for casting a card illegally are assessed.
        * 2009-10-01: You actually cast the card face-down, much as when playing a spell with Morph. It can be responded to and countered.
        * 2009-10-01: The effect that turns it face-up is a replacement effect. It doesn't use the stack and can't be responded to.
        * 2009-10-01: You may not turn a face-down spell face up. You may not turn a face-down permanent face up unless it would have morph while face up or an effect specifically allows you to turn it face up. Illusionary Mask's ability has you turn a face-down creature face up if it would assign damage, deal damage, be dealt damage, or become tapped, but not for any other reason. For example, if you use Illusionary Mask's ability to cast a black creature face down, you can't turn it face up just because it's being targeted by Terror.
        * 2009-10-01: Both the amount and types of mana you spend on {X} are taken into account while you're choosing a creature card from your hand. For example, if you spent {U}{U} on {X}, you can choose a creature card with mana cost {U}{U}, {1}{U}, {2}, or {W/U}{W/U}, among other possibilities, but not one that costs {2}{U} or one that costs {G}.
        * 2009-10-01: While the creature card is face down, it's a 2/2 creature with no name, mana cost, color, creature type, abilities, or expansion symbol. Since it has no mana cost, its converted mana cost is 0.
        * 2009-10-01: You may look at a face-down spell or permanent you control at any time.
        * 2009-10-01: You can turn a face-down permanent face up if it would have morph while face up. This applies to creatures you cast face down as a result of Illusionary Mask's effect. The rest of Illusionary Mask's effect applies to it as well.
        * 2009-10-01: Illusionary Mask's ability will continue to apply to creatures cast face down with it, even if Illusionary Mask has left the battlefield.

        *
        */
        public Illusionary_Mask() : base()
        {
            MultiverseId = 20;
            Name = "Illusionary Mask";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            Add(CardType.Artifact);

            throw new NotImplementedException("Illusionary Mask");
        }
        public Illusionary_Mask(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
