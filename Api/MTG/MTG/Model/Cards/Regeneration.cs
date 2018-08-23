using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Regeneration : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=169
            *  
            *  Enchant creature (Target a creature as you cast this. This card enters the battlefield attached to that creature.)
{G}: Regenerate enchanted creature. (The next time that creature would be destroyed this turn, it isn't. Instead tap it, remove all damage from it, and remove it from combat.)
            *  
            * Rulings

            *  
            */
        public Regeneration() : base()
        {
            MultiverseId = 169;
            Name = "Regeneration";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Regeneration");
        }
        public Regeneration(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
