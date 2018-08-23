using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Stone_Giant : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=224
            *  
            *  {T}: Target creature you control with toughness less than Stone Giant's power gains flying until end of turn. Destroy that creature at the beginning of the next end step.
            *  
            * Rulings
		2008-08-01: If the Giant's power and/or toughness change so that its toughness is less than its power, you can have the ability target the Giant itself.
		2009-10-01: To work as an evasion ability, an attacking creature must already have flying when the declare blockers step begins. Once a creature has become blocked, giving it flying won't change that.
		2009-10-01: If Stone Giant's ability is activated during a turn's end step, the delayed triggered ability won't trigger until the beginning of the next turn's end step. The targeted creature will be destroyed at that time.
		2009-10-01: When the delayed triggered ability resolves, the targeted creature is destroyed, even if it's no longer a creature, no longer under your control, or no longer has toughness less than Stone Giant's power at that time.

            *  
            */
        public Stone_Giant() : base()
        {
            MultiverseId = 224;
            Name = "Stone Giant";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.SubType.Giant);
	Add(Enumerations.CardType.Creature);
	_Power = 3;
		_Toughness = 4;

            throw new NotImplementedException("Stone Giant");
        }
        public Stone_Giant(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
