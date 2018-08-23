using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Earthbind : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=193
            *  
            *  Enchant creature
When Earthbind enters the battlefield, if enchanted creature has flying, Earthbind deals 2 damage to that creature and Earthbind gains "Enchanted creature loses flying."
            *  
            * Rulings
		2004-10-04: If the enchanted creature gains flying after Earthbind is put onto it, it will have flying. The two effects are simply applied in timestamp order.

            *  
            */
        public Earthbind() : base()
        {
            MultiverseId = 193;
            Name = "Earthbind";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Earthbind");
        }
        public Earthbind(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
