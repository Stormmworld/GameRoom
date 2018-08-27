using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Chaos_Orb : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=6
        *  
        *  {1}, {T}: If Chaos Orb is on the battlefield, flip Chaos Orb onto the battlefield from a height of at least one foot. If Chaos Orb turns over completely at least once during the flip, destroy all nontoken permanents it touches. Then destroy Chaos Orb.
        *  
        * Rulings
        * 2004-10-04: Chaos Orb can only affect permanents. Cards that are in the game but not on the battlefield, such as those in the Library and Graveyard, can't be affected.
        * 2004-10-04: You can arrange your cards any time before the Orb is put onto the battlefield, but not after. In general, you should not stack cards or put them in places where your opponent can't read the names of all of them or count them. This is recommended good gaming practice.
        * 2004-10-04: It must flip 360 degrees (that's what "flip" means). And this flip must be in the air and not in your hand.
        * 2004-10-04: This is a not a targeted ability.
        * 2004-10-04: If you have sleeves on cards, they count as the cards.
        * 2004-10-04: You can't interfere in any physical way with the casting of this card.

        *
        */
        public Chaos_Orb() : base()
        {
            MultiverseId = 6;
            Name = "Chaos Orb";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            Add(CardType.Artifact);

            throw new NotImplementedException("Chaos Orb");
        }
        public Chaos_Orb(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
