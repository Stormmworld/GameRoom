using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Veteran_Bodyguard : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=272
            *  
            *  As long as Veteran Bodyguard is untapped, all damage that would be dealt to you by unblocked creatures is dealt to Veteran Bodyguard instead.
            *  
            * Rulings
		2004-10-04: If a creature is blocked but Trample damage is still done to a player, this damage can't be redirected to the Bodyguard because the Bodyguard only takes damage from unblocked creatures.
		2004-10-04: Damage goes to the Bodyguard as long as he is untapped. This works even if he is blocking.
		2004-10-04: If you have multiple Veteran Bodyguards, you can decide which one receives the redirected damage each time damage would be dealt to you.

            *  
            */
        public Veteran_Bodyguard() : base()
        {
            MultiverseId = 272;
            Name = "Veteran Bodyguard";
	Add(Enumerations.Colors.White);
	Add(Enumerations.SubType.Human);
	Add(Enumerations.CardType.Creature);
	_Power = 2;
		_Toughness = 5;

            throw new NotImplementedException("Veteran Bodyguard");
        }
        public Veteran_Bodyguard(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
