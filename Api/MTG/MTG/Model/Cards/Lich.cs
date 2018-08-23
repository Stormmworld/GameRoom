using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Lich : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=69
            *  
            *  As Lich enters the battlefield, you lose life equal to your life total.
You don't lose the game for having 0 or less life.
If you would gain life, draw that many cards instead.
Whenever you're dealt damage, sacrifice that many nontoken permanents. If you can't, you lose the game.
When Lich is put into a graveyard from the battlefield, you lose the game.
            *  
            * Rulings
		2004-10-04: If you have multiple Lich cards on the battlefield, you must sacrifice a permanent for each damage done to you for each Lich. This is because the sacrifice is a triggered ability. But you only draw one card for each life gained regardless of how many Liches you have. This is because the draw is a replacement effect and not a triggered one. You lose if any one of the Liches leaves the battlefield.
		2004-10-04: If you take more than one damage at a time, sacrifice the permanents for that damage simultaneously. This allows you to sacrifice both a creature and any Aura that is on it all at once.
		2004-10-04: You can't pay life, just like any player at less than one life can't pay life. You can pay zero life if you want.
		2004-10-04: If an opponent steals control of Lich and no other effect prevents you from losing with a life total of zero, you will lose the game due to a zero life total as a State-Based Action before you can take any actions. The last sentence doesn't apply in this case since the Lich didn't leave the battlefield.
		2004-10-04: If an opponent steals control of Lich, their life total does not change. The life total changes for a player only when it enters the battlefield under that player's control.
		2004-10-04: You can lose life and take damage, and thereby have a negative life total, while Lich is on the battlefield.
		2010-08-15: The last ability will cause you to lose the game even if you somehow manage to have a life total greater than 0 at the time the Lich leaves the battlefield or if some other effect would prevent you from losing for having 0 life. If, on the other hand, some effect such as that from Platinum Angel says that you can't lose the game then even the last ability of the Lich cannot cause you to do so. The ability will just resolve and the game will continue as normal.
		2010-08-15: Note that usually you will have 0 or less life at the time Lich leaves the battlefield causing you to lose as a State-Based Action before the last ability can even go on the stack.
		2011-01-01: The last ability will cause you to lose the game even if you somehow manage to have a life total greater than 0 at the time the Lich is put into the graveyard or if some other effect would prevent you from losing for having 0 life. If, on the other hand, some effect such as that from Platinum Angel says that you can't lose the game then even the last ability of the Lich cannot cause you to do so. The ability will just resolve and the game will continue as normal.

            *  
            */
        public Lich() : base()
        {
            MultiverseId = 69;
            Name = "Lich";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Lich");
        }
        public Lich(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
