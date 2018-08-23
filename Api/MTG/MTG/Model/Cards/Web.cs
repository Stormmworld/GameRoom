using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Web : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=184
            *  
            *  Enchant creature (Target a creature as you cast this. This card enters the battlefield attached to that creature.)
Enchanted creature gets +0/+2 and has reach. (It can block creatures with flying.)
            *  
            * Rulings

            *  
            */
        public Web() : base()
        {
            MultiverseId = 184;
            Name = "Web";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Web");
        }
        public Web(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
