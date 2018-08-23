using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Control_Magic : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=100
            *  
            *  Enchant creature
You control enchanted creature.
            *  
            * Rulings
		2016-06-08: Gaining control of a creature doesn't cause you to gain control of any Auras or Equipment attached to it.

            *  
            */
        public Control_Magic() : base()
        {
            MultiverseId = 100;
            Name = "Control Magic";
	Add(Enumerations.Colors.Blue);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Control Magic");
        }
        public Control_Magic(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
