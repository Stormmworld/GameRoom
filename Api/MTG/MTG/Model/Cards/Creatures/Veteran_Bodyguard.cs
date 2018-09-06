using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Static;

namespace MTG.Model.Cards
{
    public class Veteran_Bodyguard : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=272
        *  
        *  As long as Veteran Bodyguard is untapped, all damage that would be dealt to you by unblocked creatures is dealt to Veteran Bodyguard instead.
        *  
        * Rulings
        * 2004-10-04: If a creature is blocked but Trample damage is still done to a player, this damage can't be redirected to the Bodyguard because the Bodyguard only takes damage from unblocked creatures.
        * 2004-10-04: Damage goes to the Bodyguard as long as he is untapped. This works even if he is blocking.
        * 2004-10-04: If you have multiple Veteran Bodyguards, you can decide which one receives the redirected damage each time damage would be dealt to you.
        *
        */
        public Veteran_Bodyguard() : base()
        {
            MultiverseId = 272;
            Name = "Veteran Bodyguard";
            Set(2, 5);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(SubType.Human);
            Add(CardType.Creature);
            Add(new BodyGuard(true));
        }
        public Veteran_Bodyguard(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
